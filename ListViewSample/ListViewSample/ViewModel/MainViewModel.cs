namespace ListViewSample.ViewModel
{
    using ListViewSample.Model;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using Xamarin.Forms;

    internal class MainViewModel : BindableObject
    {
        private ObservableCollection<OfferModel> _collectionList;

        public ObservableCollection<OfferModel> CollectionList
        {
            get => this._collectionList;
            set
            {
                this._collectionList = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand => new Command(Add);

        public ICommand DeleteCommand => new Command(Delete);

        public MainViewModel()
        {
            this.CollectionList = new ObservableCollection<OfferModel>
            {
                new OfferModel { TextName = "MM50" },
                new OfferModel { TextName = "MM50123" },
                new OfferModel { TextName = "MM50111" },
                new OfferModel { TextName = "MM5036" },
            };
        }

        private void Delete(object obj)
        {
            var model = obj as OfferModel;
            CollectionList.Remove(model);
        }

        private void Add(object obj)
        {
            var model = new OfferModel { TextName = System.Guid.NewGuid().ToString().Substring(0, 10) };
            CollectionList.Add(model);
        }
    }
}
