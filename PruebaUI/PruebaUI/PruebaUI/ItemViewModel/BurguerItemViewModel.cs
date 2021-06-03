namespace PruebaUI.ItemViewModel
{
    using GalaSoft.MvvmLight.Command;
    using PruebaUI.ViewModels;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class BurguerItemViewModel : Models.Burgue
    {
        public ICommand GotoDetailCommand => new RelayCommand(this.GotoDetail);

        private void GotoDetail()
        {
            MainViewModel.INSTANCE.FoodDetail = new FoodDetailViewModel(new Models.Burgue
            {
                Description = this.Description,
                ImageUrl = this.ImageUrl,
                Name = this.Name,
                Price = this.Price
            });
            App.Current.MainPage = new Pages.DetailFoodPage();
        }
    }
}
