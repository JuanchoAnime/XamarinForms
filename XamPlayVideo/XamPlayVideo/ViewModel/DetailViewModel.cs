namespace XamPlayVideo.ViewModel
{
    using System.Windows.Input;
    using Xamarin.Forms;
    using XamPlayVideo.Model;
    using XamPlayVideo.Pages;
    using XamPlayVideo.Service;

    public class DetailViewModel: BaseViewModel
    {
        private Movie _selectedMovie;

        public Movie SelectedMovie 
        {
            get => this._selectedMovie;
            set {
                this._selectedMovie = value;
                OnPropertyChanged(nameof(SelectedMovie));
            }
        }
        public ICommand PlayCommand => new Command(this.Play);

        private void Play()
        {
            DependencyService.Get<IPelisService>().SetFeatured(this._selectedMovie.Id);
            Application.Current.MainPage.Navigation.PushAsync(new PlayerPage(this.SelectedMovie));
        }
    }
}
