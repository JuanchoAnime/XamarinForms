namespace PrismCore
{
    using Prism;
    using Prism.Ioc;
    using PrismCore.Page;
    using PrismCore.ViewModel;
    using Xamarin.Forms;

    public partial class App
    {
        public App(IPlatformInitializer platformInitializer)
            : base(platformInitializer) { }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginViewModel>();
        }

        protected async override void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}
