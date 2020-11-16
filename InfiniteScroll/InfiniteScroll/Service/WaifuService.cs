namespace InfiniteScroll.Service
{
    using InfiniteScroll.Helper;
    using InfiniteScroll.Model;
    using Refit;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class WaifuService
    {
        public static async Task<List<Images>> GetWaifus(int page) 
        {
            IWaifuService waifuService = RestService.For<IWaifuService>(Constans.UrlApi);
            try
            {
                var data = await waifuService.GetWaifus(page);
                var users = new List<User>
                {
                    new User { IdUser = 1, Name = "Judas3991", ImgProfile = "https://cdn.myanimelist.net/images/userimages/9128492.jpg?t=1604347800" },
                    new User { IdUser = 3, Name = "Patricia", ImgProfile = "https://randomuser.me/api/portraits/women/54.jpg" },
                    new User { IdUser = 4, Name = "Joan", ImgProfile = "https://randomuser.me/api/portraits/men/24.jpg" },
                    new User { IdUser = 8, Name = "Angie", ImgProfile = "https://randomuser.me/api/portraits/women/13.jpg" },
                    new User { IdUser = 9, Name = "Jennifer", ImgProfile = "https://randomuser.me/api/portraits/women/18.jpg" },
                    new User { IdUser = 12, Name = "Luz Marina", ImgProfile = "https://randomuser.me/api/portraits/women/17.jpg" },
                    new User { IdUser = 13, Name = "Ana Maria", ImgProfile = "https://randomuser.me/api/portraits/women/91.jpg" },
                    new User { IdUser = 14, Name = "Lucia", ImgProfile = "https://randomuser.me/api/portraits/women/65.jpg" },
                    new User { IdUser = 17, Name = "Carmen", ImgProfile = "https://randomuser.me/api/portraits/women/64.jpg" },
                    new User { IdUser = 18, Name = "Jose", ImgProfile = "https://randomuser.me/api/portraits/men/46.jpg" },
                    new User { IdUser = 19, Name = "Rosa", ImgProfile = "https://randomuser.me/api/portraits/women/70.jpg" },
                    new User { IdUser = 20, Name = "Sandra", ImgProfile = "https://randomuser.me/api/portraits/women/0.jpg" },
                };

                data.Data.ForEach(w => {
                    var user = users.First(u => u.IdUser == w.IdUser);
                    w.User = user ?? new User { IdUser = 7, Name = "Francisco Javier", ImgProfile = "https://randomuser.me/api/portraits/men/3.jpg" };
                });
                return data.Data;
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
    }
}
