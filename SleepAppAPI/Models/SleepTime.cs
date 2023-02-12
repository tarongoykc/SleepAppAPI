namespace SleepAppAPI.Models
{
    public class SleepTime
    {
        public int SleepTimeID { get; set; }
        public int UserID { get; set; }
        public int SleepType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
