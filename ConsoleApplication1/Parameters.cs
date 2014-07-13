using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeLogerExtractor.DataAccess
{
    public static class Parameters
    {
        public static String SearchURL
        {
            get
            {
                //34000 340172 Montpellier
                //34170 340057 Castelnau-le-Lez
                //34970 340129 Lattes
                //34430 340270 Saint-Jean-de-Védas
                //34830 340077 Clapiers
                //34990 340123 Juvignac
                //34920 340090 Le Crès
                //34470 340198 Pérols
                //34830 340120 Jacou
                //34880 340134 Lavérune
                //34130 340240 Saint-Aunès
                //34980 340169 Montferrier-sur-Lez
                //34680 340259 Saint-Georges-d'Orques
                //34740 340327 Vendargues
                //34790 340116 Grabels
                //34250 340192 Palavas-les-Flots
                //34130 340154 Mauguio
                //34820 340309 Teyran
                //34980 340247 Saint-Clément-de-Rivière
                //34570 340295 Saussan
                //34750 340337 Villeneuve-lès-Maguelone
                //34570 340202 Pignan

                //"340022", Baillargues
                //"340058",
                //340244, Saint-Bres

                var listPostalCodeMontpel10km = new List<String>{
"340172",
//"340192",
//"340057",
"340129",
"340270",
"340077",
"340123",
"340090",
//"340198",
"340120",
"340134",
"340240",
//"340169",
"340259",
"340327",
"340116",
"340154",
"340309",
//"340247",
"340295",
"340337",
"340202",
"340022",
"340058",
"340244",
};

                var listPostalCodeVendargues = new List<String>{
"340022",
"340058",
"340240",
"340327",
                  };

                if (false)
                {
                    return String.Format("http://www.seloger.com/list.htm?ci={0}&idtt=2&idtypebien=2", String.Join("%2c", listPostalCodeVendargues));
                }
                else
                {
                    return String.Format("http://www.seloger.com/list.htm?ci={0}&idtt=2&idtypebien=2", String.Join("%2c", listPostalCodeMontpel10km));
                }
            }
        }
    }
}
