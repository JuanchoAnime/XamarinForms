
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessAppXam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClassesPage : ContentPage
    {
        public ClassesPage()
        {
            Padding = 0;
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
    }
}