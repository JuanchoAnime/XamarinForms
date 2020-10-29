namespace SharedTransition.ViewModel
{
    using SharedTransition.Model;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    internal class MainViewModel: BindableObject
    {
        private ObservableCollection<Item> _itemCollection;

        public ObservableCollection<Item> ItemCollection 
        {
            get => this._itemCollection;
            set {
                if (value == _itemCollection) return;
                this._itemCollection = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            this.ItemCollection = new ObservableCollection<Item> {
                new Item { Id = 1, Image = "adidas", Name = "ADIDAS", Price = "$ 100" },
                new Item { Id = 2, Image = "Hoody", Name = "HOODY", Price = "$ 120" },
                new Item { Id = 3, Image = "jacket", Name = "JACKET", Price = "$ 200" },
                new Item { Id = 4, Image = "adidas", Name = "ADIDAS", Price = "$ 100" },
                new Item { Id = 5, Image = "Hoody", Name = "HOODY", Price = "$ 120" },
                new Item { Id = 6, Image = "jacket", Name = "JACKET", Price = "$ 200" },
            };
        }
    }
}
