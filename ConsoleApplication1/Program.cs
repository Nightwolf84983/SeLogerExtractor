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
using System.Threading.Tasks;
using System.Threading;
using SeLogerExtractor.DataAccess.DataAccess;
using ConsoleApplication1;

namespace SeLogerExtractor.DataAccess
{


    class Program
    {
        private static bool _stopService = false;

        static void Main(string[] args)
        {
            var DatabasePath = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", DatabasePath);

            Task _task = new Task(() =>
            {
                DateTime lastExtractionDate = DateTime.Now.Date.AddDays(-1);

                while (!_stopService)
                {
                    Logger.Log("Do i do extract ?");
                    if ((DateTime.Now.Date - lastExtractionDate).TotalDays >= 1)
                    {
                        var idExtraction = DateTime.Now.Date.ToString("yyyyMMdd");
                        Logger.Log("Extraction:" + idExtraction + "  Start extraction");
                        Extractor.ExtractData(idExtraction);
                        lastExtractionDate = DateTime.Now.Date;
                        Logger.Log("Extraction:" + idExtraction + "  End extraction");
                    }

                    //Wait 10 minutes before next extraction attempt
                    int waitLimit = 0;
                    while (waitLimit < 10 && !_stopService)
                    {
                        waitLimit++;
                        Thread.Sleep(1000);
                    }
                }

                Logger.Log("Service is stopping");
            });
            _task.Start();

            Console.ReadKey();
            _stopService = true;

            Console.ReadKey();

        }
    }

    public class Extractor
    {
        public static void ExtractData(String idExtraction)
        {
            String outputDir = Path.Combine(Environment.CurrentDirectory, idExtraction);

            //try
            //{
            if (false)
            {
                Logger.Log("Extraction:" + idExtraction + "  CreateOutputDirectory");
                Logger.Log("\t" + outputDir);
                CreateOutputDirectory(outputDir);

                Logger.Log("Extraction:" + idExtraction + "  DownloadAnnonceListSource");
                DownloadAnnonceListSource(Parameters.SearchURL, idExtraction, outputDir);

                Logger.Log("Extraction:" + idExtraction + "  ExtractAnnoncesLinkFromSource");
                var annonceLinks = ExtractAnnoncesLinkFromSource(outputDir);

                Logger.Log("Extraction:" + idExtraction + "  DownloadAnnonceSource");
                DownloadAnnonceSource(annonceLinks, idExtraction, outputDir);

            }
            Logger.Log("Extraction:" + idExtraction + "  ExtractAnnoncesSource");
            var annonces = ExtractAnnoncesFromSource(outputDir);

            List<String> exVill = new List<string>{
"Saint Clement de Riviere",
"Perols",
"Castelnau le Lez",
"Castelnau-le-Lez",
"Montferrier sur Lez",

"Montferrier",
"Montferrier-sur-Lez",
"Saint-Clément-de-Rivière",
"Saint-Jean-de-Védas",
            };

            annonces = annonces.Where(a => !exVill.Contains(a.Village)).ToList();

            FormTable frm = new FormTable(annonces);
            //FormTable frm = new FormTable(annonces.Take(500).ToList());
            frm.ShowDialog();

            Logger.Log("Extraction:" + idExtraction + "  SaveToDataBase");
            //  SaveToDataBase(annonces);
            //}
            //catch (Exception ex)
            //{
            //    Logger.Log("Extraction:" + idExtraction + "  Exception");
            //    Logger.Log(ex.ToString());
            //    throw;
            //}
            //finally
            //{
            try
            {
                Logger.Log("Extraction:" + idExtraction + "  DeleteOutputDirectory");
                //  DeleteOutputDirectory(outputDir);
            }
            catch (Exception)
            {

            }
            //}
        }

        private static void CreateOutputDirectory(String outputDir)
        {
            if (Directory.Exists(outputDir))
                Directory.Delete(outputDir, true);

            Directory.CreateDirectory(outputDir);
        }

        private static void DeleteOutputDirectory(string outputDir)
        {
            if (Directory.Exists(outputDir))
                Directory.Delete(outputDir, true);
        }

        private static void DownloadAnnonceListSource(String httpRequest, String idExtraction, String outputDir)
        {
            int page = 1;
            while (true)
            {
                Logger.Log("Extraction:" + idExtraction + "  Downloading page " + page);

                String httpRequestPaged = String.Format("{0}&LISTING-LISTpg={1}", httpRequest, page);
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

                if (Regex.Matches(responseFromServer, "annonce__detail").Count == 0)
                {
                    break;
                }

                String filePath = Path.Combine(outputDir, String.Format("{0}_page_{1}.xml", idExtraction, page));
                File.WriteAllText(filePath, responseFromServer);

                page++;
            }
        }

        private static void DownloadAnnonceSource(List<String> annonceHRefs, String idExtraction, String outputDir)
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

        private static List<String> ExtractAnnoncesLinkFromSource(String outputDir)
        {
            List<String> annonceHRef = new List<string>();

            foreach (var annonceListSourcePath in Directory.GetFiles(outputDir))
            {
                String content = File.ReadAllText(annonceListSourcePath).Replace(Environment.NewLine, "").Replace("\n", "").Replace("\r", "");

                var r = Regex.Matches(content, "<a href=\"(http://www.seloger.com/annonces/achat/maison(?:(?![?]).)*)");

                foreach (Match item in r)
                    annonceHRef.Add(item.Groups[1].Value.Replace("href=\"", ""));
            }

            annonceHRef = annonceHRef.Distinct().ToList();

            return annonceHRef;
        }

        private static List<Annonce> ExtractAnnoncesFromSource(String outputDir)
        {
            List<String> atttrs = new List<string>();

            List<Annonce> annonces = new List<Annonce>();

            foreach (var file in Directory.GetFiles(outputDir, "*annonce*"))
            {
                Annonce annonce = new Annonce();


                String content = File.ReadAllText(file).Replace(Environment.NewLine, "").Replace("\n", "").Replace("\r", "");

                var regVille = Regex.Matches(content, "<input type=\"hidden\" name=\"nomville\" value=\"((?:(?![\"]).)*)");

                if (regVille.Count != 0)
                {
                    string title = regVille[0].Groups[1].Value;
                    annonce.Village = title;
                }

                var regsurface = Regex.Matches(content, "<input type=\"hidden\" name=\"surface\" value=\"((?:(?![\"]).)*)");

                if (regsurface.Count != 0)
                {
                    string title = regsurface[0].Groups[1].Value;
                    if (!String.IsNullOrWhiteSpace(title))
                        annonce.Surface = double.Parse(title);
                }

                var regtypebien = Regex.Matches(content, "<input type=\"hidden\" name=\"typebien\" value=\"((?:(?![\"]).)*)");

                if (regtypebien.Count != 0)
                {
                    string title = regtypebien[0].Groups[1].Value;
                    annonce.Title = title;
                }


                var resumeCritere = Regex.Matches(content, "<li class=\"resume__critere\">((?:(?![\b<\b]).)*)");

                if (resumeCritere.Count != 0)
                {
                    foreach (Match item in resumeCritere)
                    {
                        var text = item.Groups[1].Value;
                        if (text.Contains("Chambres"))
                            annonce.Chambres = int.Parse(text.Replace("Chambres", "").Trim());


                    }
                }


                var piscineCritere = Regex.Matches(content, "title=\" Piscine\"");

                if (piscineCritere.Count != 0)
                {
                    foreach (Match item in piscineCritere)
                    {
                        annonce.Piscine = true; ;
                    }
                }

                // <li 
                //    class="liste__item-float" 
                //    title=" Piscine">
                //     Piscine
                //</li>

                var regTerrain = Regex.Matches(content, "Terrain de ([0-9]+)(?:(?!m).)*");

                if (regTerrain.Count != 0)
                {
                    string title = regTerrain[0].Groups[1].Value;
                    if (!String.IsNullOrWhiteSpace(title))
                        annonce.Terrain = double.Parse(title);
                }

                var regAnnee = Regex.Matches(content, "Année de construction ([0-9]+)(?:(?!\").)*");

                if (regAnnee.Count != 0)
                {
                    string title = regAnnee[0].Groups[1].Value;
                    if (!String.IsNullOrWhiteSpace(title))
                        annonce.ConstuctionYear = int.Parse(title);
                }

                var regPrice = Regex.Matches(content, "<span class=\"data-price\">([0-9\\s]*)((?:(?![\b€\b]).)*)");

                if (regPrice.Count != 0)
                {
                    string title = regPrice[0].Groups[1].Value;
                    if (!String.IsNullOrWhiteSpace(title))
                        annonce.Price = int.Parse(title.Replace(" ", String.Empty).Replace(" ", ""));
                }






                annonces.Add(annonce);


            }

            return annonces;
        }

        private static void SaveToDataBase(List<Annonce> annonces)
        {
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
        }
    }
}
