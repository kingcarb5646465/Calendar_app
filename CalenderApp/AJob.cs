using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalenderApp
{
    public partial class AJob : UserControl
    {
        private PlantItem job;
        private object ckbDone;
        private PlantData job1;

        public PlantItem Job { get => job; set => job = value; }
        public AJob(PlantItem job)
        {
            InitializeComponent();

            cbStatus.DataSource = PlantItem.ListStatus;

            this.Job = job;
            ShowInfo();
        }

        public AJob(PlantData job1)
        {
            this.job1 = job1;
        }

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        void ShowInfo()
        {
            tbxJob.Text = Job.Job;
            nmFromHour.Value = Job.FromTime.X;
            nmFromMinutes.Value = Job.FromTime.Y;
            nmToHours.Value = Job.ToTime.X;
            nmToMinutes.Value = Job.ToTime.Y;
            cbStatus.SelectedIndex = PlantItem.ListStatus.IndexOf(Job.Status);
            cbDone.Checked = PlantItem.ListStatus.IndexOf(Job.Status) == (int)EPlanItem.DONE ? true : false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (deleted != null)
                deleted(this, new EventArgs());

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=127.0.0.1;Port=3306;uid=root;pwd=1234567890@;database=detail";
                MySqlConnection con = new MySqlConnection(constring);
                con.Open();

                string job = tbxJob.Text;
                Point fromTime = new Point((int)nmFromHour.Value, (int)nmFromMinutes.Value);
                Point toTime = new Point((int)nmToHours.Value, (int)nmToMinutes.Value);
                string status = cbStatus.SelectedItem.ToString();

                string sql = "UPDATE job SET job = @job, from_time_hour = @fromTimeHour, from_time_minute = @fromTimeMinute, " +
                             "to_time_hour = @toTimeHour, to_time_minute = @toTimeMinute, status = @status";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@job", job);
                cmd.Parameters.AddWithValue("@fromTimeHour", fromTime.X);
                cmd.Parameters.AddWithValue("@fromTimeMinute", fromTime.Y);
                cmd.Parameters.AddWithValue("@toTimeHour", toTime.X);
                cmd.Parameters.AddWithValue("@toTimeMinute", toTime.Y);
                cmd.Parameters.AddWithValue("@status", status);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dữ liệu đã được cập nhật thành công vào cơ sở dữ liệu!");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void cbDone_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = cbDone.Checked ? (int)EPlanItem.DONE : (int)EPlanItem.DOING;
            //string statusString = ((EPlanItem)cbStatus.SelectedIndex).ToString();
            //Job.Status = statusString;


        }
    }
}
