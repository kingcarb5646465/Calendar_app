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
    public partial class DailyPlant : Form
    {
        private DateTime date;
        public DateTime Date { get => date; set => date = value; }
        public PlantData Job { get => job; set => job = value; }

        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public DailyPlant(DateTime date, PlantData job)
        {
            InitializeComponent();

            this.Date = date;
            this.Job = job;
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;

            pnlJob.Controls.Add(fPanel);


        }
        private PlantData job;


        void ShowJobByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (Job != null && Job.Job != null)
            {
                List<PlantItem> todayJob = GetJobByDay(date);
                for (global::System.Int32 i = 0; i < todayJob.Count; i++)
                {
                    AddJob(todayJob[i]);
                }
            }
        }

        private void aJob_Deleted(object? sender, EventArgs e)
        {
            AJob uc = sender as AJob;
            PlantItem job = uc.Job;

            fPanel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }

        private void aJob_Edited(object? sender, EventArgs e)
        {
           
        }

        void AddJob(PlantItem job)
        {
            AJob aJob = new AJob(job);
            aJob.Edited += aJob_Edited;
            aJob.Deleted += aJob_Deleted;
            fPanel.Controls.Add(aJob);
        }
        List<PlantItem> GetJobByDay(DateTime date)
        {
            return Job.Job.Where(p => p.Date.Year == date.Year && p.Date.Month == date.Month && p.Date.Day == date.Day).ToList();
        }

        private void DtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }

        private void mnsaddJob_Click(object sender, EventArgs e)
        {
            PlantItem item = new PlantItem() { Date = dtpkDate.Value};
            Job.Job.Add(item);
            AddJob(item);
        }

        private void mnstoday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }
    }
}
