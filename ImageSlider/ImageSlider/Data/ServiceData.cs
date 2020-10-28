namespace ImageSlider.Data
{
    using ImageSlider.Model;
    using System.Collections.Generic;

    public class ServiceData
    {
        public IList<ImageCarousel> FindAll() 
        {
            return new List<ImageCarousel>
            {
                new ImageCarousel { Id = 1, Image = "classic", Color = "White" },
                new ImageCarousel { Id = 2, Image = "elegantCol", Color = "White" },
                new ImageCarousel { Id = 3, Image = "womenCol", Color = "White" },
            };
        }
    }
}
