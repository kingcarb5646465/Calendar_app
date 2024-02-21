
namespace CalenderApp
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            cbStatus = new ComboBox();
            nmToMinutes = new NumericUpDown();
            nmToHours = new NumericUpDown();
            label1 = new Label();
            nmFromMinutes = new NumericUpDown();
            nmFromHour = new NumericUpDown();
            tbxJob = new TextBox();
            cbDone = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmToMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmToHours).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmFromMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmFromHour).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tbxJob);
            panel1.Controls.Add(cbDone);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(996, 47);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(cbStatus);
            panel2.Controls.Add(nmToMinutes);
            panel2.Controls.Add(nmToHours);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(nmFromMinutes);
            panel2.Controls.Add(nmFromHour);
            panel2.Location = new Point(381, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 44);
            panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(518, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(66, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(443, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(55, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(274, 9);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(151, 28);
            cbStatus.TabIndex = 5;
            // 
            // nmToMinutes
            // 
            nmToMinutes.Location = new Point(209, 10);
            nmToMinutes.Name = "nmToMinutes";
            nmToMinutes.Size = new Size(42, 27);
            nmToMinutes.TabIndex = 4;
            nmToMinutes.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // nmToHours
            // 
            nmToHours.Location = new Point(161, 10);
            nmToHours.Name = "nmToHours";
            nmToHours.Size = new Size(42, 27);
            nmToHours.TabIndex = 3;
            nmToHours.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 14);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 2;
            label1.Text = "To";
            // 
            // nmFromMinutes
            // 
            nmFromMinutes.Location = new Point(57, 10);
            nmFromMinutes.Name = "nmFromMinutes";
            nmFromMinutes.Size = new Size(42, 27);
            nmFromMinutes.TabIndex = 1;
            // 
            // nmFromHour
            // 
            nmFromHour.Location = new Point(9, 10);
            nmFromHour.Name = "nmFromHour";
            nmFromHour.Size = new Size(42, 27);
            nmFromHour.TabIndex = 0;
            // 
            // tbxJob
            // 
            tbxJob.Location = new Point(49, 13);
            tbxJob.Name = "tbxJob";
            tbxJob.Size = new Size(308, 27);
            tbxJob.TabIndex = 1;
            // 
            // cbDone
            // 
            cbDone.AutoSize = true;
            cbDone.Location = new Point(25, 17);
            cbDone.Name = "cbDone";
            cbDone.Size = new Size(18, 17);
            cbDone.TabIndex = 0;
            cbDone.UseVisualStyleBackColor = true;
            cbDone.CheckedChanged += cbDone_CheckedChanged;
            // 
            // AJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AJob";
            Size = new Size(1017, 53);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmToMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmToHours).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmFromMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmFromHour).EndInit();
            ResumeLayout(false);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Panel panel1;
        private CheckBox cbDone;
        private TextBox tbxJob;
        private Panel panel2;
        private NumericUpDown nmFromMinutes;
        private NumericUpDown nmFromHour;
        private NumericUpDown nmToMinutes;
        private NumericUpDown nmToHours;
        private Label label1;
        private ComboBox cbStatus;
        private Button btnEdit;
        private Button btnDelete;
    }
}
