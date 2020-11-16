namespace InfiniteScroll.ViewModel
{
    using InfiniteScroll.Model;
    using InfiniteScroll.Service;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading.Tasks;
    using Xamarin.Forms;

    public class MainViewModel: BindableObject
    {
        private ObservableCollection<InstagramModel> _items;
        public ObservableCollection<InstagramModel> Items
        {
            get { return _items; }
            set {
                _items = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<InstagramModel> _histories;
        public ObservableCollection<InstagramModel> Histories
        {
            get { return _histories; }
            set {
                _histories = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() 
        {
            GetData();
            Histories = new ObservableCollection<InstagramModel>(new List<InstagramModel> {
                new InstagramModel { ProfilePicture = "https://randomuser.me/api/portraits/women/65.jpg", UserName = "Lucia" },
                new InstagramModel { ProfilePicture = "https://randomuser.me/api/portraits/women/0.jpg", UserName = "Sandra" },
                new InstagramModel { ProfilePicture = "https://randomuser.me/api/portraits/men/46.jpg", UserName = "Jose" },
                new InstagramModel { ProfilePicture = "https://randomuser.me/api/portraits/women/54.jpg", UserName = "Patricia" },
                new InstagramModel { ProfilePicture = "https://randomuser.me/api/portraits/men/24.jpg", UserName = "Joan" },
                new InstagramModel { ProfilePicture = "https://randomuser.me/api/portraits/women/64.jpg", UserName = "Carmen" },
                new InstagramModel { ProfilePicture = "https://randomuser.me/api/portraits/women/13.jpg", UserName = "Angie" },
                new InstagramModel { ProfilePicture = "https://randomuser.me/api/portraits/women/18.jpg", UserName = "Jennifer" },
                new InstagramModel { ProfilePicture = "https://randomuser.me/api/portraits/women/17.jpg", UserName = "Luz Marina" },
                new InstagramModel { ProfilePicture = "https://randomuser.me/api/portraits/women/70.jpg", UserName = "Rosa" },
                new InstagramModel { ProfilePicture = "https://randomuser.me/api/portraits/women/91.jpg", UserName = "Ana Maria" },
                new InstagramModel { UserName = "Francisco Javier", ProfilePicture = "https://randomuser.me/api/portraits/men/3.jpg" }
            });
        }

        private async Task GetData()
        {
            var waifus = await WaifuService.GetWaifus(1);
            Items = new ObservableCollection<InstagramModel>(
                waifus.Select(w => new InstagramModel { PostImage = w.Image, ProfilePicture = w.User.ImgProfile, UserName = w.User.Name })
            );
        }
    }
}
