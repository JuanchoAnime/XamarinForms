namespace PrismCore
{
    using Prism;
    using Prism.Ioc;
    using PrismCore.Page;
    using PrismCore.Service;
    using PrismCore.ViewModel;
    using Xamarin.Forms;

    public partial class App
    {
        public App(IPlatformInitializer platformInitializer)
            : base(platformInitializer) { }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<CountryService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<ContriesPage, CountriesViewModel>();

            containerRegistry.RegisterForNavigation<LandPage, LandViewModel>();
        }

        protected async override void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"NavigationPage/{nameof(ContriesPage)}");
        }

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}
