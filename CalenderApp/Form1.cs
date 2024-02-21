using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace CalenderApp
{
    public partial class Form1 : Form
    {

        #region Properties
        
        private List<List<Button>> matrix;

        private string filePath = "data.xml";
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

      

        public int AppTime { get => appTime; set => appTime = value; }

        private PlantData Job;

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };



        #endregion
        public Form1()
        {
            InitializeComponent();
            //Notify = new NotifyIcon();
            AppTime = 0;
            LoadMatrix();

            try
            {
                Job = (PlantData)DeserializeFromXML(filePath);
            }
            catch
            {
                setDefaultJob();
            }

        }

        void setDefaultJob()
        {
            Job = new PlantData();
            Job.Job = new List<PlantItem>();
            Job.Job.Add(new PlantItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Thu nghiem",
                Status = PlantItem.ListStatus[(int)EPlanItem.COMING]
            });

        }

        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (global::System.Int32 j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth + Cons.margin, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    btn.Click += btn_Click;
                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }
            SetDefaultDate();
        }

        private NotifyIcon GetNotify()
        {
            return Notify;
        }


        private int appTime;
        private void btn_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;

            DailyPlant daily = new DailyPlant(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);

            daily.ShowDialog();
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)

                        return 29;

                    else
                        return 28;

                default:
                    return 30; ;
            }
        }
        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if (isEqualDate(useDate, DateTime.Now))//màu cho ngày hiện tại
                {
                    btn.BackColor = Color.Plum;
                }
                if (isEqualDate(useDate, date)) //màu cho ngày mình chọn
                {
                    btn.BackColor = Color.Chocolate;
                }

                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);
            }

        }

        bool isEqualDate(DateTime date1, DateTime date2)
        {
            return (date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day);
        }
        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (global::System.Int32 j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.AliceBlue;
                }
            }
        }



        private void btnThursday_Click(object sender, EventArgs e)
        {

        }
      

        void SetDefaultDate() //dc goi sau khi load matrix thanh xong
        {
            dtpkDate.Value = DateTime.Now;
        }
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnNextmonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnLastMonth_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnToday_Click_1(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

       
        private void SerializeToXML(object data, string filePath) //lu du lieu xuong
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlantData));

            sr.Serialize(fs, data);
            fs.Close();
        }

        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlantData));
                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch (Exception e)
            {
                fs.Close();
                throw new NotImplementedException();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, filePath);
        }

        private void tmNotify_Tick(object sender, EventArgs e)
        {
            if(ckbNotify.Checked)
                return;
            AppTime++;
            if (AppTime < Cons.notifyTime)
                return;
            if (Job == null || Job.Job == null)
                return;
            DateTime currentDate = DateTime.Now;
            List<PlantItem> todayjobs = Job.Job.Where(p => p.Date.Year == currentDate.Year && p.Date.Month == currentDate.Month && p.Date.Day == currentDate.Day).ToList();
            GetNotify().ShowBalloonTip(Cons.notifyTimeOut, "Lịch công việc", string.Format("Bạn có {0} công việc trong ngày hôm nay", todayjobs.Count), ToolTipIcon.Info);
            AppTime = 0;
        }

     
        private void nmUpDown_ValueChanged(object sender, EventArgs e)
        {
            Cons.notifyTime = (int)nmNotify.Value;
        }

        private void ckbNotify_CheckedChanged(object sender, EventArgs e)
        {
            nmNotify.Enabled = ckbNotify.Checked; 
        }
    }
}
