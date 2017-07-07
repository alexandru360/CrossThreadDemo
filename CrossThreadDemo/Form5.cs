using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form5 : Form
    {
        private Button button1;
        private ProgressBar progressBar1;

        private delegate void ReadFileDelegate(string path);

        public Form5()
        {
            InitializeComponent();
        }

        //private void InitializeComponent()
        //{
        //    this.button1 = new System.Windows.Forms.Button();
        //    this.progressBar1 = new System.Windows.Forms.ProgressBar();
        //    this.SuspendLayout();
        //    // 
        //    // button1
        //    // 
        //    this.button1.Location = new System.Drawing.Point(104, 190);
        //    this.button1.Name = "button1";
        //    this.button1.Size = new System.Drawing.Size(75, 23);
        //    this.button1.TabIndex = 0;
        //    this.button1.Text = "button1";
        //    this.button1.UseVisualStyleBackColor = true;
        //    this.button1.Click += new System.EventHandler(this.button1_Click);
        //    // 
        //    // progressBar1
        //    // 
        //    this.progressBar1.Location = new System.Drawing.Point(44, 47);
        //    this.progressBar1.Maximum = 500;
        //    this.progressBar1.Name = "progressBar1";
        //    this.progressBar1.Size = new System.Drawing.Size(208, 23);
        //    this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
        //    this.progressBar1.TabIndex = 1;
        //    // 
        //    // Form5
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 262);
        //    this.Controls.Add(this.progressBar1);
        //    this.Controls.Add(this.button1);
        //    this.Name = "Form5";
        //    this.ResumeLayout(false);

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            new ReadFileDelegate(ReadFile).BeginInvoke("C:\\2_Work\\MyTests\\abc.txt", null, null);
        }

        private void WorkDone()
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Value = 500;
        }


        private void ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                Thread.Sleep(3000);
                sr.ReadToEnd();
            }

            //this.Invoke(new MethodInvoker(WorkDone));
            this.Invoke(new MethodInvoker(delegate { WorkDone(); }));
        }
    }
}