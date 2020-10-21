namespace Expander.Model
{
    using System;
    using System.Collections.ObjectModel;

    public class Agenda
    {
        public string Topic { get; set; }

        public string Duration { get; set; }

        public string Color { get; set; }

        public DateTime Date { get; set; }

        public ObservableCollection<Speaker> Speakers { get; set; }
    }
}
