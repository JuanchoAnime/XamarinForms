namespace XamPlayVideo.ViewModel
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    using Xamarin.Forms;
    using XamPlayVideo.Model;
    using XamPlayVideo.Pages;
    using XamPlayVideo.Service;

    public class WatchListViewModel : BaseViewModel
    {
        private ObservableCollection<Movie> _movies;
        private Movie _selectedMovie;

        public WatchListViewModel()
        {
            Movies = new ObservableCollection<Movie>(DependencyService.Get<IPelisService>().GetMovies());
        }

        public Movie SelectedMovie 
        {
            get => this._selectedMovie;
            set {
                this._selectedMovie = value;
                OnPropertyChanged(nameof(this.SelectedMovie));
            }
        }

        public ObservableCollection<Movie> Movies 
        {
            get => this._movies;
            set {
                this._movies = value;
                OnPropertyChanged(nameof(this.Movies));
                OnPropertyChanged(nameof(FeatureMovie));
            }
        }

        public Movie FeatureMovie => this.Movies?.Where(x => x.IsFeatured).FirstOrDefault();

        public ICommand PlayCommand => new Command(this.Play);

        public ICommand SelectionCommand => new Command(() => {
            if (SelectedMovie != null) {
                var vm = new DetailViewModel { SelectedMovie = SelectedMovie };
                Application.Current.MainPage.Navigation.PushAsync(new DetailPage { BindingContext = vm });
            }
        });

        private void Play(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new PlayerPage(this.FeatureMovie));
        }
    }
}
