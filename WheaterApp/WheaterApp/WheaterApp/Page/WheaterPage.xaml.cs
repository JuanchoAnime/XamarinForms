using System.Threading.Tasks;
using WheaterApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WheaterApp.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WheaterPage : ContentPage
    {
        private readonly WeatherViewModel vm;

        public WheaterPage()
        {
            InitializeComponent();
            vm = WeatherViewModel.INSTANCE ?? new WeatherViewModel();
            this.GetCity();
        }

        private async Task GetCity()
        {
            var data = await vm.GetCity();
            lblCiudad.Text = $"{data.City.Name}, {data.City.Country}";
            lblDate.Text = data.DayNow;
            listTemperatures.ItemsSource = data.Temperatures;
        }
    }
}