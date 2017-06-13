namespace CrossThreadDemo
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textPercent = new System.Windows.Forms.TextBox();
            this.btnStartProgress = new System.Windows.Forms.Button();
            this.timerCtl = new System.Windows.Forms.Timer(this.components);
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 94);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(517, 23);
            this.progressBar.TabIndex = 0;
            // 
            // textPercent
            // 
            this.textPercent.BackColor = System.Drawing.SystemColors.Control;
            this.textPercent.Location = new System.Drawing.Point(13, 68);
            this.textPercent.Name = "textPercent";
            this.textPercent.ReadOnly = true;
            this.textPercent.Size = new System.Drawing.Size(516, 20);
            this.textPercent.TabIndex = 1;
            // 
            // btnStartProgress
            // 
            this.btnStartProgress.Location = new System.Drawing.Point(13, 13);
            this.btnStartProgress.Name = "btnStartProgress";
            this.btnStartProgress.Size = new System.Drawing.Size(107, 35);
            this.btnStartProgress.TabIndex = 2;
            this.btnStartProgress.Text = "Start";
            this.btnStartProgress.UseVisualStyleBackColor = true;
            this.btnStartProgress.Click += new System.EventHandler(this.btnStartProgress_Click);
            // 
            // timerCtl
            // 
            this.timerCtl.Tick += new System.EventHandler(this.timerCtl_Tick);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(126, 12);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(107, 35);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 140);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.btnStartProgress);
            this.Controls.Add(this.textPercent);
            this.Controls.Add(this.progressBar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textPercent;
        private System.Windows.Forms.Button btnStartProgress;
        private System.Windows.Forms.Timer timerCtl;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Button buttonCancel;
    }
}