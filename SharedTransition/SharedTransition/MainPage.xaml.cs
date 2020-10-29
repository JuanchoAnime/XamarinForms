namespace SharedTransition
{
    using Plugin.SharedTransitions;
    using SharedTransition.Model;
    using SharedTransition.Page;
    using SharedTransition.ViewModel;
    using System.Linq;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private async void MyItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any()) 
            {
                MyItems.SelectedItem = null;
                var getItemSelectData = e.CurrentSelection.FirstOrDefault() as Item;
                SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, getItemSelectData.Id.ToString());
                await Navigation.PushAsync(new MainPageDetails(getItemSelectData));
            }
        }
    }
}
