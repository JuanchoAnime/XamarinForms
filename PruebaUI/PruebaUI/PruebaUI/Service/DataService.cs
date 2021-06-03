namespace PruebaUI.Service
{
    using PruebaUI.Models;
    using System.Collections.Generic;

    public class DataService : IDataService
    {
        public List<Burgue> GetAllBurgues()
        {
            return new List<Burgue>
            {
                new Burgue { Name = "CLASSIC", Price = 12.99f, ImageUrl = "classic.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies"},
                new Burgue { Name = "DOUBLE", Price = 19.99f, ImageUrl = "two.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies"},
                new Burgue { Name = "SHARK", Price = 17.29f, ImageUrl = "shark.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies"},
                new Burgue { Name = "CHICKEN", Price = 15.99f, ImageUrl = "chicken.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies"},
                new Burgue { Name = "MEAT", Price = 11.99f, ImageUrl = "meat.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies"},
                new Burgue { Name = "BBQ", Price = 13.99f, ImageUrl = "bbq.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies"}

            };
        }
    }
}
