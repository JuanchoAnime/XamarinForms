namespace PrismCore.ViewModel
{
    using Prism.Mvvm;
    using Prism.Navigation;

    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        public INavigationService NavigationService { get; private set; }

        public string Title { get; set; }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public void Destroy() { }

        public void Initialize(INavigationParameters parameters) { }

        public void OnNavigatedFrom(INavigationParameters parameters) { }

        public void OnNavigatedTo(INavigationParameters parameters) { }
    }
}
