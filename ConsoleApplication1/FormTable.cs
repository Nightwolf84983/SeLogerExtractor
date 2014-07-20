using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SeLogerExtractor.DataAccess.DataAccess;
using DevExpress.XtraCharts;

namespace ConsoleApplication1
{
    public partial class FormTable : Form
    {
        Criteria Criteria = new Criteria();
        StudyResult StudyResult = new StudyResult();
        List<Annonce> list = new List<Annonce>();
        List<Annonce> listFiltered = new List<Annonce>();
        public FormTable()
        {
            InitializeComponent();
        }
        public FormTable(List<Annonce> list)
            : this()
        {
            this.StudyResult.Surface = Criteria.SurfaceCible;
            this.StudyResult.Terrain = Criteria.TerrainCible;

            this.list = list;

            Criteria.PropertyChanged += new PropertyChangedEventHandler(Criteria_PropertyChanged);
            StudyResult.PropertyChanged += new PropertyChangedEventHandler(StudyResult_PropertyChanged);
            RefreshAll();

            this.criteriaBindingSource.DataSource = Criteria;
            this.productBindingSource.DataSource = StudyResult;
        }



        void Criteria_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "TerrainMin"
                || e.PropertyName == "TerrainMax"
                || e.PropertyName == "SurfaceMin"
                || e.PropertyName == "SurfaceMax"
                || e.PropertyName == "FilterOnPiscine"
                || e.PropertyName == "Criteria.WithPiscine"
                )
            {
                RefreshAll();
            }
        }

        void StudyResult_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RefreshStudy();
        }

        private void RefreshAll()
        {
            Filter(this.list);

            RefreshDistribution();

            RefreshStudy();
        }

        private void RefreshStudy()
        {
            StudyResult.PropertyChanged -= new PropertyChangedEventHandler(StudyResult_PropertyChanged);

            this.StudyResult.PrixSurfaceMCarre = (int)GetMedian(listFiltered.Select(a => a.PrixM2).ToArray());
            this.StudyResult.PrixTerrainMCarre = (int)GetMedian(listFiltered.Select(a => a.PrixM2Terrain).ToArray());
            this.StudyResult.PrixCalcule = (int)((this.StudyResult.Surface * this.StudyResult.PrixSurfaceMCarre) * (double)0.8 + (this.StudyResult.Terrain * this.StudyResult.PrixTerrainMCarre) * 0.2);

            StudyResult.PropertyChanged += new PropertyChangedEventHandler(StudyResult_PropertyChanged);
        }

        private void RefreshDistribution()
        {

            var s = chartControl1.Series[0];
            s.Points.Clear();
            if (listFiltered.Count > 0)
            {
                var values = listFiltered.Select(a => (double?)a.PrixM2).ToList();
                var min = (double)values.Min();
                var max = (double)values.Max();
                var range = max - min;
                var partition = values.Count / 30 + 10;
                var v = Distribution(values, min, range, partition).Select(a => new SeriesPoint(a.Key, a.Value)).ToArray();
                s.Points.AddRange(v);
            }
        }

        private static Dictionary<double, int> Distribution(List<double?> decValues, double min, double range, int divisionCount)
        {
            Dictionary<double, int> distribution = new Dictionary<double, int>();

            double interval = range / divisionCount;

            if (interval == 0)
                return distribution;

            double rangeMin = min;
            double rangeMax = min + interval;

            for (int i = 0; i < divisionCount; i++)
            {
                double key = (rangeMax - rangeMin) / 2 + rangeMin;
                int value = decValues.Where(a => rangeMin <= a && a < rangeMax).Count();
                distribution.Add(key, value);
                rangeMin = rangeMax;
                rangeMax += interval;
            }
            return distribution;
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
                                        && (!Criteria.FilterOnPiscine || a.Piscine == Criteria.WithPiscine)
                                        ).ToList();

            this.annonceBindingSource.DataSource = listFiltered;
            this.annonceGridControl.RefreshDataSource();

            this.lblCount.Text = String.Format("{0} Annonces", listFiltered.Count);

            this.villePrixBindingSource.DataSource = listFiltered.GroupBy(a => a.Village).Select(a => new VillePrix
            {
                Ville = a.Key,
                PrixM2 = (int)a.Average(b => b.PrixM2),
                PrixTerrainM2 = (int)a.Average(b => b.PrixM2Terrain),
                Count = a.Count()
            }).ToList();
            this.villePrixGridControl.RefreshDataSource();
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            this.annonceGridControl.ExportToXlsx(@"C:\Users\Utilisateur\Desktop\seloger.xlsx");
            this.annonceGridControl.ExportToCsv(@"C:\Users\Utilisateur\Desktop\seloger.csv");
        }
    }

    public class Criteria : INotifyPropertyChanged
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

        private int _SurfaceCible;

        public int SurfaceCible
        {
            get { return _SurfaceCible; }
            set
            {
                _SurfaceCible = value;
                SurfaceMin = (int)((double)_SurfaceCible * (1 - (double)_variationSurface / 100));
                SurfaceMax = (int)((double)_SurfaceCible * (1 + (double)_variationSurface / 100));
                NotifyPropertyChanged("SurfaceCible");
            }
        }

        private int _variationSurface;

        public int VariationSurface
        {
            get { return _variationSurface; }
            set
            {
                _variationSurface = value;
                SurfaceCible = SurfaceCible;
                NotifyPropertyChanged("VariationSurface");
            }
        }

        private int _TerrainCible;

        public int TerrainCible
        {
            get { return _TerrainCible; }
            set
            {
                _TerrainCible = value;
                TerrainMin = (int)((double)_TerrainCible * (1 - (double)_variationTerrain / 100));
                TerrainMax = (int)((double)_TerrainCible * (1 + (double)_variationTerrain / 100));
                NotifyPropertyChanged("TerrainCible");
            }
        }

        private int _variationTerrain;

        public int VariationTerrain
        {
            get { return _variationTerrain; }
            set
            {
                _variationTerrain = value;
                TerrainCible = TerrainCible;
                NotifyPropertyChanged("VariationTerrain");
            }
        }

        private bool _filterOnPiscine;

        public bool FilterOnPiscine
        {
            get { return _filterOnPiscine; }
            set
            {
                _filterOnPiscine = value;
                NotifyPropertyChanged("FilterOnPiscine");
            }
        }

        private bool _withPiscine;

        public bool WithPiscine
        {
            get { return _withPiscine; }
            set
            {
                _withPiscine = value;
                NotifyPropertyChanged("WithPiscine");
            }
        }


        public Criteria()
        {
            //SurfaceMin = 80;
            //SurfaceMax = 130;
            //TerrainMin = 200;
            //TerrainMax = 600;
            _variationSurface = 15;
            SurfaceCible = 115;

            _variationTerrain = 15;
            TerrainCible = 339;
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

    public class StudyResult : INotifyPropertyChanged
    {
        private int _surface;

        public int Surface
        {
            get { return _surface; }
            set
            {
                _surface = value;
                NotifyPropertyChanged("Surface");
            }
        }

        private int _Terrain;

        public int Terrain
        {
            get { return _Terrain; }
            set
            {
                _Terrain = value;
                NotifyPropertyChanged("Terrain");
            }
        }

        private int _PrixPropose;

        public int PrixPropose
        {
            get { return _PrixPropose; }
            set
            {
                _PrixPropose = value;
                NotifyPropertyChanged("PrixPropose");
            }
        }

        private int _PrixCalcule;

        public int PrixCalcule
        {
            get { return _PrixCalcule; }
            set
            {
                _PrixCalcule = value;

                NotifyPropertyChanged("PrixCalcule");

                PrixCalculeMoins10 = (int)(_PrixCalcule * 0.9);
            }
        }

        private int _PrixCalculeMoins10;

        public int PrixCalculeMoins10
        {
            get { return _PrixCalculeMoins10; }
            set
            {
                _PrixCalculeMoins10 = value;

                NotifyPropertyChanged("PrixCalculeMoins10");
            }
        }

        private int _PrixSurfaceMCarre;

        public int PrixSurfaceMCarre
        {
            get { return _PrixSurfaceMCarre; }
            set
            {
                _PrixSurfaceMCarre = value;

                NotifyPropertyChanged("PrixSurfaceMCarre");
            }
        }

        private int _PrixTerrainMCarre;

        public int PrixTerrainMCarre
        {
            get { return _PrixTerrainMCarre; }
            set
            {
                _PrixTerrainMCarre = value;

                NotifyPropertyChanged("PrixTerrainMCarre");
            }
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

    public class VillePrix
    {
        public String Ville { get; set; }
        public int PrixM2 { get; set; }
        public int PrixTerrainM2 { get; set; }
        public int Count { get; set; }
    }
}
