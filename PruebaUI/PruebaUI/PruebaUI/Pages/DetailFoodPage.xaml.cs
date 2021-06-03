
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebaUI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailFoodPage : ContentPage
    {
        public DetailFoodPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            App.Current.MainPage = new MainTabPage();
            return true;
        }
    }
}