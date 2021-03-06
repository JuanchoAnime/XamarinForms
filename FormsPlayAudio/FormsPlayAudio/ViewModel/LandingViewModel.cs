namespace FormsPlayAudio.ViewModel
{
    using System.Linq;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using Xamarin.Forms;
    using FormsPlayAudio.Model;
    using FormsPlayAudio.View;
    using FormsPlayAudio.Service;
    using System;

    public class LandingViewModel: BaseViewModel
    {
        private ObservableCollection<Music> _musicList;
        private Music _recentMusic;
        private Music _selectedMusic;

        public LandingViewModel()
        {
            this.MusicList = SongService.GetInstance().Music;
            RecentMusic = MusicList.Where(m => m.IsRecent).FirstOrDefault();
        }

        #region Properties
        public ObservableCollection<Music> MusicList
        {
            get => this._musicList;
            set => this.SetProperty(ref this._musicList ,value);
        }

        public Music RecentMusic
        {
            get => this._recentMusic;
            set => this.SetProperty(ref this._recentMusic, value);
        }

        public Music SelectedMusic
        {
            get => this._selectedMusic;
            set => this.SetProperty(ref this._selectedMusic, value);
        }

        public ICommand SelectionCommand => new Command(PlayMusic);

        public ICommand PlayRecentCommand => new Command(PlayRecent);

        #endregion

        private void PlayMusic(object obj)
        {
            if (SelectedMusic != null)
            {
                var viewModel = new PlayerViewModel(SelectedMusic);
                var playerPage = new PlayerPage() { BindingContext = viewModel };

                Application.Current.MainPage = playerPage;
            }
        }

        private void PlayRecent(object obj)
        {
            var viewModel = new PlayerViewModel(RecentMusic);
            var playerPage = new PlayerPage() { BindingContext = viewModel };

            Application.Current.MainPage = playerPage;
        }
    }
}