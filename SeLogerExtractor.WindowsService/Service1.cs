using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using SeLogerExtractor.DataAccess;
using System.Threading;

namespace SeLogerExtractor.WindowsService
{
    public partial class Service : ServiceBase
    {
        private bool _stopService = false;

        public Service()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Task _task = new Task(() =>
            {
                DateTime lastExtractionDate = DateTime.Now.Date.AddDays(-1);

                while (!_stopService)
                {
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
                    while (waitLimit < 600 && !_stopService)
                    {
                        waitLimit++;
                        Thread.Sleep(1000);
                    }
                }
            });
            _task.Start();
        }

        protected override void OnStop()
        {
            _stopService = true;
        }
    }
}
