using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using ConsoleApplication1.DataAccess;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var DatabasePath = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", DatabasePath);

            //String httpRequest = "http://www.seloger.com/recherche.htm?ci=340022,340058,340240,340327&idtt=2&idtypebien=1,2&pxmax=300000&pxmin=290000&tri=a_px";
            String httpRequest = "http://www.seloger.com/recherche.htm?ci=340022,340058,340240,340327&idtt=2&idtypebien=1,2&tri=a_px";

            String idExtraction = "20140127";

            String outputDir = Path.Combine(Environment.CurrentDirectory, idExtraction);

            //ExtractAnnonceListSource(httpRequest, idExtraction, outputDir);

            //List<String> annonceHRef = ExtractAnnoncesLink(outputDir);

            //ExtractAnnonceSource(annonceHRef, idExtraction, outputDir);

            var annonces = ProcessAnnonceFile(outputDir);

            using (ModelSeLogerContainer ctx = new ModelSeLogerContainer())
            {
                foreach (var annonce in annonces)
                {
                    //New
                    if (!ctx.Annonce.Any(a => a.Id.Equals(annonce.Id)))
                    {
                        annonce.DateStart = DateTime.Now.Date;
                        annonce.DateUpdate = DateTime.Now.Date;
                        annonce.Version = 0;
                        annonce.IsCurrentVersion = true;

                        ctx.Annonce.AddObject(annonce);
                    }
                    else
                    {
                        var existingAnnonce = ctx.Annonce.Single(a => a.IsCurrentVersion && a.Id.Equals(annonce.Id));

                        //New Vesion
                        if (annonce.Price != existingAnnonce.Price)
                        {
                            existingAnnonce.IsCurrentVersion = false;
                            existingAnnonce.DateUpdate = DateTime.Now.Date;

                            annonce.DateStart = DateTime.Now.Date;
                            annonce.DateUpdate = DateTime.Now.Date;
                            annonce.Version = existingAnnonce.Version + 1;
                            annonce.IsCurrentVersion = true;

                            ctx.Annonce.AddObject(annonce);
                        }
                        //Update Vesion
                        else
                        {
                            existingAnnonce.Title = annonce.Title;
                            existingAnnonce.Village = annonce.Village;
                            existingAnnonce.Price = annonce.Price;
                            existingAnnonce.ConstuctionYear = annonce.ConstuctionYear;
                            existingAnnonce.Surface = annonce.Surface;
                            existingAnnonce.Terrain = annonce.Terrain;
                            existingAnnonce.Piscine = annonce.Piscine;
                            existingAnnonce.Terasse = annonce.Terasse;
                            existingAnnonce.Chambres = annonce.Chambres;
                            existingAnnonce.Pieces = annonce.Pieces;
                            existingAnnonce.Parkings = annonce.Parkings;
                            existingAnnonce.Attributes = annonce.Attributes;

                            annonce.DateUpdate = DateTime.Now.Date;
                        }
                    }

                }
                ctx.SaveChanges();
            }

            //FormTable frm = new FormTable(annonces);
            //frm.ShowDialog();

            Console.ReadKey();
        }

        private static void ExtractAnnonceListSource(String httpRequest, String idExtraction, String outputDir)
        {
            if (Directory.Exists(outputDir))
                Directory.Delete(outputDir, true);

            Directory.CreateDirectory(outputDir);

            int page = 1;
            while (true)
            {
                Console.WriteLine("Start page " + page);
                String httpRequestPaged = String.Format("{0}&ANNONCEpg={1}", httpRequest, page);
                WebRequest request = WebRequest.Create(httpRequestPaged);

                WebResponse response = request.GetResponse();

                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();

                // Clean up the streams and the response.
                reader.Close();
                response.Close();

                if (Regex.Matches(responseFromServer, "annonce__detail").Count == 3)
                {
                    Console.WriteLine("End reached");
                    break;
                }

                String filePath = Path.Combine(outputDir, String.Format("{0}_page_{1}.xml", idExtraction, page));
                File.WriteAllText(filePath, responseFromServer);

                Console.Write(" End page" + page);

                page++;
            }
        }

        private static void ExtractAnnonceSource(List<String> annonceHRefs, String idExtraction, String outputDir)
        {
            int annonce = 1;

            foreach (var annonceHRef in annonceHRefs)
            {
                try
                {
                    string responseFromServer = String.Empty;

                    WebRequest request = WebRequest.Create(annonceHRef);
                    using (WebResponse response = request.GetResponse())
                    {
                        // Get the stream containing content returned by the server.
                        Stream dataStream = response.GetResponseStream();
                        // Open the stream using a StreamReader for easy access.
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            // Read the content.
                            responseFromServer = reader.ReadToEnd();

                            // Clean up the streams and the response.
                            reader.Close();
                        }
                        response.Close();
                    }

                    String filePath = Path.Combine(outputDir, String.Format("{0}_annonce_{1}.xml", idExtraction, annonce));
                    File.WriteAllText(filePath, responseFromServer);
                }
                catch (Exception)
                {


                }

                annonce++;
            }
        }

        private static List<String> ExtractAnnoncesLink(String outputDir)
        {
            List<String> annonceHRef = new List<string>();

            foreach (var annonceListSourcePath in Directory.GetFiles(outputDir))
            {
                String content = File.ReadAllText(annonceListSourcePath).Replace(Environment.NewLine, "").Replace("\n", "").Replace("\r", "");

                var r = Regex.Matches(content, "(<div class=\"annonce__detail\">\\s*<a class=\"annone__detail__title annonce__link\" )(href=[\'\"]?([^\'\" >]+))");

                foreach (Match item in r)
                    annonceHRef.Add(item.Groups[2].Value.Replace("href=\"", ""));
            }
            return annonceHRef;
        }

        private static List<Annonce> ProcessAnnonceFile(String outputDir)
        {
            List<String> atttrs = new List<string>();

            List<Annonce> annonces = new List<Annonce>();

            foreach (var file in Directory.GetFiles(outputDir, "*annonce*"))
            {
                Annonce annonce = new Annonce();


                String content = File.ReadAllText(file).Replace(Environment.NewLine, "").Replace("\n", "").Replace("\r", "");

                var regID = Regex.Matches(content, "<input type=\"hidden\" name=\"idannonce\" id=\"idannonce\" value=\"([^\"]+)\"/>");

                if (regID.Count != 0)
                {
                    Int32 id = Int32.Parse(regID[0].Groups[1].Value);
                    annonce.Id = id;
                 
                }
                else
                {
                    continue;
                }

                var regTitle = Regex.Matches(content, "(<span class=\"data-title\">)(?<=[>])([^<>]+)(?=[<])");

                if (regTitle.Count != 0)
                {
                    string title = regTitle[0].Groups[2].Value;
                    annonce.Title = title;
                }

                var regPrice = Regex.Matches(content, "(<span class=\"data-price\">)(.*[€])( <)");

                if (regPrice.Count != 0)
                {
                    double price = double.Parse(regPrice[0].Groups[2].Value.Replace(" ", "").Replace("€", ""));
                    annonce.Price = price;
                }

                var regItemSwitch = Regex.Matches(content, "(liste__item-switch\")\\s*(title=\")([^\">]+)");

                if (regItemSwitch.Count != 0)
                {
                    foreach (Match item in regItemSwitch)
                    {
                        string attribute = item.Groups[3].Value;

                        if (attribute.StartsWith("Année de construction "))
                            annonce.ConstuctionYear = Int32.Parse(attribute.Replace("Année de construction ", ""));

                        if (attribute.StartsWith("Surface de "))
                            annonce.Surface = Int32.Parse(attribute.Replace("Surface de ", "").Replace("m²", "").Trim());

                        if (attribute.StartsWith("Terrain de "))
                            annonce.Terrain = Int32.Parse(attribute.Replace("Terrain de ", "").Replace("m²", "").Trim());

                        if (attribute.StartsWith("Piscine"))
                            annonce.Piscine = true;

                        if (attribute.Contains("Terrasse"))
                            annonce.Terasse = true;


                        if (attribute.Contains("Pièces"))
                        {
                            var regex = Regex.Matches(attribute, "([0-9]+) (Pièce)");
                            if (regex.Count != 0)
                            {
                                annonce.Pieces = Int32.Parse(regex[0].Groups[1].Value);
                            }
                        }

                        if (attribute.Contains("Chambre"))
                        {
                            var regex = Regex.Matches(attribute, "([0-9]+) (Chambre)");
                            if (regex.Count != 0)
                            {
                                annonce.Chambres = Int32.Parse(regex[0].Groups[1].Value);
                            }
                        }

                        if (attribute.Contains("Parking"))
                        {
                            var regex = Regex.Matches(attribute, "([0-9]+) (Parking)");
                            if (regex.Count != 0)
                            {
                                annonce.Parkings = Int32.Parse(regex[0].Groups[1].Value);
                            }
                        }
                    }
                }
                annonces.Add(annonce);
            }

            return annonces;
        }
    }
}
