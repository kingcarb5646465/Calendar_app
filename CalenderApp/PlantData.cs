using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderApp
{
    [Serializable]
    public class PlantData
    {
        private List<PlantItem> job;
        public List<PlantItem> Job { get; set; } = new();
        public List<PlantItem> Job1 { get => job; set => job = value; }
    }

}
