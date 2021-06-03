namespace PruebaUI.Models
{
    public class EventModel
    {
        public System.DateTime Date { get; set; }

        public System.TimeSpan Time { get; set; }

        public string Title { get; set; }

        public string Day => $"{this.Date.Day}";

        public string Hour => Time.Hours.ToString("00");

        public string Minute => Time.Minutes.ToString("00");

        public string Second => Time.Seconds.ToString("00");

        public string BgColor { get; set; }
    }
}
