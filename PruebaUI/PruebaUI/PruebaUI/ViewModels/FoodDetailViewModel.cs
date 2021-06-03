namespace PruebaUI.ViewModels
{
    using PruebaUI.Models;

    public class FoodDetailViewModel : BaseViewModel
    {
        public FoodDetailViewModel(Burgue burgue)
        {
            Burgue = burgue;
        }

        public Burgue Burgue { get; }
    }
}
