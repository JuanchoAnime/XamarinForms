namespace XamPlayVideo.Pages
{
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WatchListPage : ContentPage
    {
        public WatchListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            moviesCollection.SelectedItem = null;
            base.OnAppearing();
        }
    }
}