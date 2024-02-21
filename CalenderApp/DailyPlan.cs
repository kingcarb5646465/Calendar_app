
namespace CalenderApp
{
    internal class DailyPlan
    {
        private DateTime dateTime;
        private PlantData job;

        public DailyPlan(DateTime dateTime, PlantData job)
        {
            this.dateTime = dateTime;
            this.job = job;
        }
    }
}