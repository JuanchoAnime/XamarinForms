namespace Lands.ViewModels
{
    using Prism.Mvvm;
    using Prism.Navigation;

    public class BaseViewModel : BindableBase, INavigationAware, IDestructible
    {
        private string _title;

        protected INavigationService NavigationService { get; private set; }

        public string Title
        {
            get => this._title;
            set => SetProperty(ref this._title, value);
        }

        public BaseViewModel(INavigationService navigationService) => this.NavigationService = navigationService;

        public virtual void Destroy() { }

        public virtual void OnNavigatedFrom(INavigationParameters parameters) { }

        public virtual void OnNavigatingTo(INavigationParameters parameters) { }

        public virtual void OnNavigatedTo(INavigationParameters parameters) { }
    }
}
