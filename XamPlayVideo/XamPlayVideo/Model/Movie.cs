namespace XamPlayVideo.Model
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Synopsis { get; set; }

        public string Thumbnail { get; set; }

        public string Url { get; set; }

        public bool IsFeatured { get; set; }
    }
}
