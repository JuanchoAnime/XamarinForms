﻿namespace EventTracker.Model
{
    using System;

    public class Event
    {
        public string Title { get; set; }

        public string Venue { get; set; }

        public string Duration { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public DateTime Date { get; set; }
    }
}
