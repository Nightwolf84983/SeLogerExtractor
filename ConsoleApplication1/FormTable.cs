using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SeLogerExtractor.DataAccess.DataAccess;

namespace ConsoleApplication1
{
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
        }
        public FormTable(List<Annonce> list)
        {
            InitializeComponent();

            this.annonceBindingSource.DataSource = list;

            MessageBox.Show(String.Format("PrixM2 mediane m2: {0}", GetMedian(list.Select(a => a.PrixM2).ToArray())));
            MessageBox.Show(String.Format("PrixM2Terrain mediane m2: {0}", GetMedian(list.Select(a => a.PrixM2Terrain).ToArray())));
        }

        public static double GetMedian(double[] sourceNumbers)
        {
            //Framework 2.0 version of this method. there is an easier way in F4        
            if (sourceNumbers == null || sourceNumbers.Length == 0)
                return 0D;

            //make sure the list is sorted, but use a new array
            double[] sortedPNumbers = (double[])sourceNumbers.Clone();
            sourceNumbers.CopyTo(sortedPNumbers, 0);
            Array.Sort(sortedPNumbers);

            //get the median
            int size = sortedPNumbers.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)sortedPNumbers[mid] : ((double)sortedPNumbers[mid] + (double)sortedPNumbers[mid - 1]) / 2;
            return median;
        }
    }


}
