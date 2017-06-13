using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossThreadDemo
{
    public partial class Form2 : Form
    {
        private BackgroundWorker backgroundWorker;
        private string textMessage = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.textBox1.Text = textMessage;
        }

        private void setTextBackgroundWorkerBtn_Click(object sender, EventArgs e)
        {
            textMessage = "This text was set safely by BackgroundWorker.";
            this.backgroundWorker2.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textMessage = "This text was set safely by BackgroundWorker. button 2";
            this.backgroundWorker2.RunWorkerAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textMessage = "This text was set safely by BackgroundWorker. button 3";
            this.backgroundWorker2.RunWorkerAsync();
        }
    }
}
