namespace PrismCore.ViewModel
{
    using Prism.Mvvm;
    using Prism.Navigation;
    using Xamarin.Forms;

    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        public INavigationService NavigationService { get; private set; }

        public string Title { get; set; }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void Destroy() { }

        public virtual void Initialize(INavigationParameters parameters) { }

        public virtual void OnNavigatedFrom(INavigationParameters parameters) { }

        public virtual void OnNavigatedTo(INavigationParameters parameters) { }

        public string GetStringForDistionary(string key) => Application.Current.Resources[key].ToString();
    }
}
