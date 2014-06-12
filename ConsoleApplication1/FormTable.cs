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
        Criteria Criteria = new Criteria();
        List<Annonce> list = new List<Annonce>();
        List<Annonce> listFiltered = new List<Annonce>();
        public FormTable()
        {
            InitializeComponent();
        }
        public FormTable(List<Annonce> list)
            : this()
        {
            this.list = list;

            Filter(this.list);

            this.criteriaBindingSource.DataSource = Criteria;

            //MessageBox.Show(String.Format("PrixM2 mediane m2: {0}", GetMedian(list.Select(a => a.PrixM2).ToArray())));
            //MessageBox.Show(String.Format("PrixM2Terrain mediane m2: {0}", GetMedian(list.Select(a => a.PrixM2Terrain).ToArray())));
        }

        private void Filter(List<Annonce> list)
        {
            listFiltered = list.Where(a => a.Terrain != null
                                        && a.Terrain >= Criteria.TerrainMin
                                        && a.Terrain <= Criteria.TerrainMax
                                        && a.Surface != null
                                        && a.Surface >= Criteria.SurfaceMin
                                        && a.Surface <= Criteria.SurfaceMax
                                        && a.Price != null
                                        && a.Chambres >= 3
                                        ).ToList();

            this.annonceBindingSource.DataSource = listFiltered;
            this.annonceGridControl.RefreshDataSource();

            this.lblCount.Text = String.Format("{0} Annonces", listFiltered.Count);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter(this.list);
        }
    }

    public class Criteria
    {
        public int SurfaceMin
        {
            get { return _surfaceMin; }
            set
            {
                _surfaceMin = value;
                NotifyPropertyChanged("SurfaceMin");
            }
        }
        private int _surfaceMin;

        public int TerrainMin
        {
            get { return _TerrainMin; }
            set
            {
                _TerrainMin = value;
                NotifyPropertyChanged("TerrainMin");
            }
        }
        private int _TerrainMin;

        public int SurfaceMax
        {
            get { return _surfaceMax; }
            set
            {
                _surfaceMax = value;
                NotifyPropertyChanged("SurfaceMax");
            }
        }
        private int _surfaceMax;

        public int TerrainMax
        {
            get { return _TerrainMax; }
            set
            {
                _TerrainMax = value;
                NotifyPropertyChanged("TerrainMax");
            }
        }
        private int _TerrainMax;

        public Criteria()
        {
            SurfaceMin = 80;
            SurfaceMax = 130;
            TerrainMin = 200;
            TerrainMax = 600;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property. 
        // The CallerMemberName attribute that is applied to the optional propertyName 
        // parameter causes the property name of the caller to be substituted as an argument. 
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }


}
