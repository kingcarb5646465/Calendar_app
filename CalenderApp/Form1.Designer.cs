namespace CalenderApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            nmNotify = new NumericUpDown();
            ckbNotify = new CheckBox();
            btnToday = new Button();
            dtpkDate = new DateTimePicker();
            panel2 = new Panel();
            pnlMatrix = new Panel();
            panel4 = new Panel();
            btnSaturday = new Button();
            btnNextmonth = new Button();
            btnLastMonth = new Button();
            btnSunday = new Button();
            btnFriday = new Button();
            btnThursday = new Button();
            btnWendnesday = new Button();
            btnTuesday = new Button();
            btnMonday = new Button();
            tmNotify = new System.Windows.Forms.Timer(components);
            Notify = new NotifyIcon(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmNotify).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1189, 634);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(btnToday);
            panel3.Controls.Add(dtpkDate);
            panel3.Location = new Point(7, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1175, 53);
            panel3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(nmNotify);
            panel6.Controls.Add(ckbNotify);
            panel6.Location = new Point(3, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(335, 49);
            panel6.TabIndex = 2;
            // 
            // nmNotify
            // 
            nmNotify.Location = new Point(118, 11);
            nmNotify.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            nmNotify.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmNotify.Name = "nmNotify";
            nmNotify.Size = new Size(89, 27);
            nmNotify.TabIndex = 1;
            nmNotify.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nmNotify.ValueChanged += nmUpDown_ValueChanged;
            // 
            // ckbNotify
            // 
            ckbNotify.AutoSize = true;
            ckbNotify.Enabled = false;
            ckbNotify.Location = new Point(31, 12);
            ckbNotify.Name = "ckbNotify";
            ckbNotify.Size = new Size(72, 24);
            ckbNotify.TabIndex = 0;
            ckbNotify.Text = "Notify";
            ckbNotify.UseVisualStyleBackColor = true;
            ckbNotify.CheckedChanged += ckbNotify_CheckedChanged;
            // 
            // btnToday
            // 
            btnToday.Location = new Point(714, 10);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(94, 29);
            btnToday.TabIndex = 1;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = true;
            btnToday.Click += btnToday_Click_1;
            // 
            // dtpkDate
            // 
            dtpkDate.Location = new Point(443, 12);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(250, 27);
            dtpkDate.TabIndex = 0;
            dtpkDate.ValueChanged += dtpkDate_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlMatrix);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(3, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(1179, 562);
            panel2.TabIndex = 0;
            // 
            // pnlMatrix
            // 
            pnlMatrix.Location = new Point(150, 79);
            pnlMatrix.Name = "pnlMatrix";
            pnlMatrix.Size = new Size(895, 463);
            pnlMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSaturday);
            panel4.Controls.Add(btnNextmonth);
            panel4.Controls.Add(btnLastMonth);
            panel4.Controls.Add(btnSunday);
            panel4.Controls.Add(btnFriday);
            panel4.Controls.Add(btnThursday);
            panel4.Controls.Add(btnWendnesday);
            panel4.Controls.Add(btnTuesday);
            panel4.Controls.Add(btnMonday);
            panel4.Location = new Point(4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1172, 70);
            panel4.TabIndex = 0;
            // 
            // btnSaturday
            // 
            btnSaturday.Location = new Point(782, 3);
            btnSaturday.Name = "btnSaturday";
            btnSaturday.Size = new Size(115, 64);
            btnSaturday.TabIndex = 9;
            btnSaturday.Text = "Saturday";
            btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnNextmonth
            // 
            btnNextmonth.Location = new Point(1053, 7);
            btnNextmonth.Name = "btnNextmonth";
            btnNextmonth.Size = new Size(92, 51);
            btnNextmonth.TabIndex = 8;
            btnNextmonth.Text = "NextMonth";
            btnNextmonth.UseVisualStyleBackColor = true;
            btnNextmonth.Click += btnNextmonth_Click;
            // 
            // btnLastMonth
            // 
            btnLastMonth.Location = new Point(14, 7);
            btnLastMonth.Name = "btnLastMonth";
            btnLastMonth.Size = new Size(92, 51);
            btnLastMonth.TabIndex = 7;
            btnLastMonth.Text = "LastMonth";
            btnLastMonth.UseVisualStyleBackColor = true;
            btnLastMonth.Click += btnLastMonth_Click;
            // 
            // btnSunday
            // 
            btnSunday.Location = new Point(903, 3);
            btnSunday.Name = "btnSunday";
            btnSunday.Size = new Size(127, 64);
            btnSunday.TabIndex = 6;
            btnSunday.Text = "Sunday";
            btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            btnFriday.Location = new Point(650, 3);
            btnFriday.Name = "btnFriday";
            btnFriday.Size = new Size(126, 64);
            btnFriday.TabIndex = 4;
            btnFriday.Text = "Friday";
            btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            btnThursday.Location = new Point(522, 3);
            btnThursday.Name = "btnThursday";
            btnThursday.Size = new Size(122, 64);
            btnThursday.TabIndex = 3;
            btnThursday.Text = "Thursday";
            btnThursday.UseVisualStyleBackColor = true;
            btnThursday.Click += btnThursday_Click;
            // 
            // btnWendnesday
            // 
            btnWendnesday.Location = new Point(397, 3);
            btnWendnesday.Name = "btnWendnesday";
            btnWendnesday.Size = new Size(119, 64);
            btnWendnesday.TabIndex = 2;
            btnWendnesday.Text = "Wendnesday";
            btnWendnesday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            btnTuesday.Location = new Point(272, 3);
            btnTuesday.Name = "btnTuesday";
            btnTuesday.Size = new Size(119, 64);
            btnTuesday.TabIndex = 1;
            btnTuesday.Text = "Tuesnday";
            btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            btnMonday.Location = new Point(146, 3);
            btnMonday.Name = "btnMonday";
            btnMonday.Size = new Size(120, 64);
            btnMonday.TabIndex = 0;
            btnMonday.Text = "Monday";
            btnMonday.UseVisualStyleBackColor = true;
            // 
            // tmNotify
            // 
            tmNotify.Enabled = true;
            tmNotify.Interval = 60000;
            tmNotify.Tick += tmNotify_Tick;
            // 
            // Notify
            // 
            Notify.Icon = (Icon)resources.GetObject("Notify.Icon");
            Notify.Text = "notifyIcon1";
            Notify.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 635);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmNotify).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DateTimePicker dtpkDate;
        private Panel panel2;
        private Panel panel4;
        private Button btnToday;
        private Panel pnlMatrix;
        private Button btnMonday;
        private Button btnThursday;
        private Button btnWendnesday;
        private Button btnTuesday;
        private Button btnSunday;
        private Button btnSatrurday;
        private Button btnFriday;
        private Button btnNextmonth;
        private Button btnLastMonth;
        private Panel panel6;
        private CheckBox ckbNotify;
        private NumericUpDown nmNotify;
        private Button btnSaturday;
        private System.Windows.Forms.Timer tmNotify;
        private NotifyIcon Notify;
    }
}
