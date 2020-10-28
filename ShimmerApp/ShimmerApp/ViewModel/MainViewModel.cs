using ShimmerApp.Model;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShimmerApp.ViewModel
{
    public class MainViewModel: BindableObject
    {
        private ObservableCollection<Product> products;
        private bool isBusy;

        public ObservableCollection<Product> Products
        {
            get => this.products;
            set { 
                this.products = value;
                OnPropertyChanged();
            }
        }

        public ICommand RefreshCommand => new Command(Refresh);

        private void Refresh(object obj)
        {
            this.GetProducts();
        }

        public bool IsBusy 
        {
            get => this.isBusy;
            set { 
                this.isBusy = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            this.IsBusy = true;
            GetProducts();
        }

        private async Task GetProducts()
        {
            this.IsBusy = true;
            this.Products = new ObservableCollection<Product>
            {
                new Product { Image = "resturant", Title = "Resturant Title", SubTitle = "Resturant SubTitle", IsBusy = true },
                new Product { Image = "resturant2", Title = "Resturant2 Title", SubTitle = "Resturant2 SubTitle", IsBusy = true },
                new Product { Image = "resturant3", Title = "Resturant3 Title", SubTitle = "Resturant3 SubTitle", IsBusy = true },
                new Product { Image = "resturant4", Title = "Resturant4 Title", SubTitle = "Resturant4 SubTitle", IsBusy = true },
            };
            await Task.Delay(3000);
            this.Products = new ObservableCollection<Product>
            {
                new Product { Image = "resturant", Title = "Restaurant Tokyo Cafe", SubTitle = "Non-Directional Beacon" },
                new Product { Image = "resturant2", Title = "Restaurant Texas Cafe", SubTitle = "Non-Directional Beacon" },
                new Product { Image = "resturant3", Title = "Restaurant New Work Cafe", SubTitle = "Non-Directional Beacon" },
                new Product { Image = "resturant4", Title = "Restaurant Florida Cafe", SubTitle = "Non-Directional Beacon" },
            };
            this.IsBusy = false;
        }
    }
}
