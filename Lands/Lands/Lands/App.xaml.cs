namespace Lands
{
    using Xamarin.Forms;
    using Views;
    using Prism.Unity;
    using Prism.Ioc;
    using Prism;
    using Lands.ViewModels;
    using Lands.Servicios;

    public partial class App : PrismApplication
    {
        public App():this(null)
        {

        }
        public App(IPlatformInitializer platformInitializer): base(platformInitializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/LandsPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IApiService, ApiService>();
            
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LandsPage, LandsViewModel>();
            containerRegistry.RegisterForNavigation<LandTabbedPage, LandViewModel>();
        }
    }
}
