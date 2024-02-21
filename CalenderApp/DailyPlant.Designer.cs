namespace CalenderApp
{
    partial class DailyPlant
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
            panel1 = new Panel();
            panel3 = new Panel();
            btnYesterday = new Button();
            btnNextDay = new Button();
            dtpkDate = new DateTimePicker();
            pnlJob = new Panel();
            mnsMain = new MenuStrip();
            mnsaddJob = new ToolStripMenuItem();
            mnstoday = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            mnsMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pnlJob);
            panel1.Location = new Point(2, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 623);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnYesterday);
            panel3.Controls.Add(btnNextDay);
            panel3.Controls.Add(dtpkDate);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1026, 33);
            panel3.TabIndex = 1;
            // 
            // btnYesterday
            // 
            btnYesterday.Location = new Point(27, 3);
            btnYesterday.Name = "btnYesterday";
            btnYesterday.Size = new Size(94, 29);
            btnYesterday.TabIndex = 3;
            btnYesterday.Text = "YesterDay";
            btnYesterday.UseVisualStyleBackColor = true;
            btnYesterday.Click += btnYesterday_Click;
            // 
            // btnNextDay
            // 
            btnNextDay.Location = new Point(935, 0);
            btnNextDay.Name = "btnNextDay";
            btnNextDay.Size = new Size(82, 29);
            btnNextDay.TabIndex = 2;
            btnNextDay.Text = "NextDay";
            btnNextDay.UseVisualStyleBackColor = true;
            btnNextDay.Click += btnNextDay_Click;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(382, 5);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(250, 27);
            dtpkDate.TabIndex = 1;
            dtpkDate.ValueChanged += DtpkDate_ValueChanged;
            // 
            // pnlJob
            // 
            pnlJob.Location = new Point(3, 42);
            pnlJob.Name = "pnlJob";
            pnlJob.Size = new Size(1026, 578);
            pnlJob.TabIndex = 0;
            // 
            // mnsMain
            // 
            mnsMain.ImageScalingSize = new Size(20, 20);
            mnsMain.Items.AddRange(new ToolStripItem[] { mnsaddJob, mnstoday });
            mnsMain.Location = new Point(0, 0);
            mnsMain.Name = "mnsMain";
            mnsMain.Size = new Size(1045, 28);
            mnsMain.TabIndex = 1;
            mnsMain.Text = "menuStrip1";
            // 
            // mnsaddJob
            // 
            mnsaddJob.Name = "mnsaddJob";
            mnsaddJob.Size = new Size(77, 24);
            mnsaddJob.Text = "Add job";
            mnsaddJob.Click += mnsaddJob_Click;
            // 
            // mnstoday
            // 
            mnstoday.Name = "mnstoday";
            mnstoday.Size = new Size(63, 24);
            mnstoday.Text = "Today";
            mnstoday.Click += mnstoday_Click;
            // 
            // DailyPlant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 666);
            Controls.Add(panel1);
            Controls.Add(mnsMain);
            MainMenuStrip = mnsMain;
            Name = "DailyPlant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DailyPlant";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            mnsMain.ResumeLayout(false);
            mnsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtpkDate;
        private Panel pnlJob;
        private MenuStrip mnsMain;
        private ToolStripMenuItem mnsaddJob;
        private ToolStripMenuItem mnstoday;
        private Panel panel3;
        private Button btnYesterday;
        private Button btnNextDay;
    }
}