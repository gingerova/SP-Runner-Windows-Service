using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace deneme
{
    public partial class RunDataSynchronizer : ServiceBase
    {
        private Timer timer;
        sqlConn cnn = new sqlConn();
        string str = "";
        string fp = "";
        public RunDataSynchronizer()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (timer == null)
            {
                timer = new Timer();
            }
            timer.Interval = 60000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            str = ConfigurationManager.AppSettings["CONNECTIONSTRING"].ToString();
            cnn.runSP(str);
            timer.Start();
        }

        protected override void OnStop()
        {
        }
    }
}
