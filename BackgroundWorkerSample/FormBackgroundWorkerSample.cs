using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace JCCC.Samples.BackgroundWorkerSample
{
    public partial class FormBackgroundWorkerSample : Form
    {
        public FormBackgroundWorkerSample()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                int duration = (int)nudDuration.Value;
                backgroundWorker.RunWorkerAsync(new TimeSpan(duration * 1000 * 1000 * 10));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.WorkerSupportsCancellation)
            {
                backgroundWorker.CancelAsync();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            TimeSpan duration = (TimeSpan)e.Argument;

            DateTime expiration = DateTime.Now + duration;

            worker.ReportProgress(0);
            e.Result = 0;
            while (DateTime.Now < expiration)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                TimeSpan remaining = expiration - DateTime.Now;
                e.Result = duration.TotalSeconds - remaining.TotalSeconds;
                int percent = 100 - (int)(100 * (remaining.TotalMilliseconds / duration.TotalMilliseconds));
                worker.ReportProgress(percent);

                // Sleep to give the UI thread a chance to process
                // updates.
                Thread.Sleep(100);
            }

            if (!e.Cancel)
            {
                e.Result = duration.TotalSeconds;
                worker.ReportProgress(100);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbProgress.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Cancelled", "Result");
            }
            else
            {
                MessageBox.Show(String.Format("Finished: {0} seconds", e.Result), "Result");
            }
        }
    }
}
