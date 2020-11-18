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
    using Xamarin.Forms.Extended;

    public class MainViewModel: BindableObject
    {
        private InfiniteScrollCollection<InstagramModel> _items;
        private int page = 1;

        public InfiniteScrollCollection<InstagramModel> Items
        {
            get { return _items; }
            set {
                _items = value;
                OnPropertyChanged();
            }
        }

        private bool _isBussy;

        public bool IsBussy
        {
            get { return _isBussy; }
            set {
                _isBussy = value;
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
            Items = new InfiniteScrollCollection<InstagramModel>
            {
                OnLoadMore = async () => {
                    IsBussy = true;
                    var items = await GetWaifus();
                    IsBussy = false;
                    return items;
                }
            };
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
            Items.AddRange(await GetWaifus());
        }

        private async Task<List<InstagramModel>> GetWaifus()
        {
            var waifus = await WaifuService.GetWaifus(page);
            page++;
            if (waifus.Count == 0) page = page--;
            return waifus.Select(w => new InstagramModel { PostImage = w.Image, ProfilePicture = w.User.ImgProfile, UserName = w.User.Name }).ToList();
        }
    }
}
