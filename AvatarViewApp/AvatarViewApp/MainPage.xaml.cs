namespace AvatarViewApp
{
    using AvatarViewApp.ViewModel;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
