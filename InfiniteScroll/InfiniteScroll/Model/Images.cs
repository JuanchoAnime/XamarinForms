using System.Collections.Generic;

namespace InfiniteScroll.Model
{
    public class Response
    {
        public List<Images> Data { get; set; }
    }

    public class Images
    {
        public int IdUser { get; set; }

        public string Image { get; set; }

        public User User { get; set; }
    }

    public class User 
    {
        public int IdUser { get; set; }

        public string Name { get; set; }

        public string ImgProfile { get; set; }
    }
}
