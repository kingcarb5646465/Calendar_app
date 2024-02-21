using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderApp
{
    public class PlantItem
    {
        private DateTime date;
        private string job;
        public string Job 
        {
            get { return job; }
            set { job = value; }
        }

        public Point FromTime { get => fromTime; set => fromTime = value; }
        public Point ToTime { get => toTime; set => toTime = value; }
        public string Status { get => status; set => status = value; }
        public DateTime Date { get => date; set => date = value; }

        private Point fromTime;

        private Point toTime;

        private string status;

        public static List<string> ListStatus = new List<string>() { "DONE", "DOING", "COMING", "MISSED"};

        
    }
    public enum EPlanItem //định nghĩa các giá trị hằng số 
    {
        DONE,
        DOING,
        COMING,
        MISSED
    }
}
