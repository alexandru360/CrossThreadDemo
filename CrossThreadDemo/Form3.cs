using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace CrossThreadDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(100);
                sum = sum + i;
                // Calling ReportProgress() method raises ProgressChanged event
                // To this method pass the percentage of processing that is complete
                bgWorker.ReportProgress(i);

                // Check if the cancellation is requested
                if (bgWorker.CancellationPending)
                {
                    // Set Cancel property of DoWorkEventArgs object to true
                    e.Cancel = true;
                    // Reset progress percentage to ZERO and return
                    bgWorker.ReportProgress(0);
                    return;
                }
            }
            e.Result = sum;
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            textPercent.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                textPercent.Text = "Processing cancelled";
            }
            else if (e.Error != null)
            {
                textPercent.Text = e.Error.Message;
            }
            else
            {
                textPercent.Text = e.Result.ToString();
            }
        }

        private void btnStartProgress_Click(object sender, EventArgs e)
        {
            // Check if the backgroundWorker is already busy running the asynchronous operation
            //if (!bgWorker.IsBusy)
            //{
            //    // This method will start the execution asynchronously in the background
            //    bgWorker.RunWorkerAsync();
            //}
            timerCtl.Enabled = true;
            timerCtl.Start();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            timerCtl.Stop();

            if (bgWorker.IsBusy)
            {
                // Cancel the asynchronous operation if still in progress
                bgWorker.CancelAsync();
            }
        }

        private void timerCtl_Tick(object sender, EventArgs e)
        {
            // Check if the backgroundWorker is already busy running the asynchronous operation
            if (!bgWorker.IsBusy)
            {
                // This method will start the execution asynchronously in the background
                bgWorker.RunWorkerAsync();
            }
        }
    }
}
