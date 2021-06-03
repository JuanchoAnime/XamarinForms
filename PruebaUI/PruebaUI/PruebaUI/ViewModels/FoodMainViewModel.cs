namespace PruebaUI.ViewModels
{
    using PruebaUI.ItemViewModel;
    using PruebaUI.Service;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Xamarin.Forms;

    public class FoodMainViewModel: BaseViewModel
    {
        private readonly IDataService _dataService;
        private ObservableCollection<BurguerItemViewModel> _burguers;

        public ObservableCollection<BurguerItemViewModel> Burguers
        {
            get => this._burguers;
            set => this.SetProperty(ref this._burguers, value);
        }

        public FoodMainViewModel()
        {
            this._dataService = DependencyService.Get<IDataService>();
            this.Burguers = new ObservableCollection<BurguerItemViewModel>(_dataService.GetAllBurgues().Select(b => new BurguerItemViewModel { 
                ImageUrl = b.ImageUrl,
                Name = b.Name,
                Price = b.Price,
                Description = b.Description
            }));
        }
    }
}
