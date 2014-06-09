using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SeLogerExtractor.DataAccess.DataAccess
{
    public partial class Annonce
    {
      

        public double PrixM2
        {
            get { return (double)((Price) ?? 0) / (Surface ?? Int32.MaxValue); }
        }


        public double PrixM2Terrain
        {
            get { return (double)((Price) ?? 0) / (Terrain ?? Int32.MaxValue); }
        }


     
    }
}
