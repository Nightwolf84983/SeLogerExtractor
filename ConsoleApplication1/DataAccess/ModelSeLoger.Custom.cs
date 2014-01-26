using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.DataAccess
{
    public partial class Annonce
    {
      

        public double PrixM2
        {
            get { return (double)((Price) ?? 0) / (Surface ?? Int32.MaxValue); }
        }


     
    }
}
