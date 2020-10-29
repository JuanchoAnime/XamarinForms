namespace SharedTransition.Page
{
    using SharedTransition.Model;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageDetails : ContentPage
    {
        public MainPageDetails(Item item)
        {
            InitializeComponent();
            MyImage.Source = item.Image;
            MyLabel.Text = item.Price;
        }
    }
}