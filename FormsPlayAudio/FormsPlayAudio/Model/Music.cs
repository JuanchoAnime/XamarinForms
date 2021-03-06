﻿namespace FormsPlayAudio.Model
{
    public class Music
    {
        public string Title { get; set; }

        public string Artist { get; set; }

        public string Direction { get; set; }

        public string Url { get; set; }

        public string CoverImage { get; set; } = "https://usercontent2.hubstatic.com/14548043_f1024.jpg";

        public bool IsRecent { get; set; } = false;
    }
}
