namespace FormsPlayAudio.ViewModel
{
    using System;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using Xamarin.Essentials;
    using Xamarin.Forms;
    using FormsPlayAudio.Model;
    using FormsPlayAudio.View;
    using FormsPlayAudio.Service;
    using Plugin.SimpleAudioPlayer;
    using System.IO;
    using System.Reflection;

    public class PlayerViewModel : BaseViewModel
    {
        private Music _selectedMusic;
        private ObservableCollection<Music> _musicList;
        private TimeSpan _duration;
        private double _maximun = 100f;
        private TimeSpan _position;
        private bool _isPlaying;
        private readonly ISimpleAudioPlayer _audioPlayer;

        public PlayerViewModel(Music selectedMusic)
        {
            SelectedMusic = selectedMusic;
            MusicList = SongService.GetInstance().Music;
            SongService.GetInstance().SetRecient(MusicList.IndexOf(SelectedMusic));

            this._audioPlayer = CrossSimpleAudioPlayer.Current;
            this._audioPlayer.Load(GetStreamForFile());
            this._audioPlayer.Play();
        }

        private Stream GetStreamForFile()
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            return assembly.GetManifestResourceStream("FormsPlayAudio." + SelectedMusic.Direction);
        }

        #region Properties

        public Music SelectedMusic
        {
            get => this._selectedMusic;
            set => this.SetProperty(ref this._selectedMusic, value);
        }
        public ObservableCollection<Music> MusicList
        {
            get => this._musicList;
            set => this.SetProperty(ref this._musicList, value);
        }

        public TimeSpan Duration
        {
            get => this._duration;
            set => this.SetProperty(ref this._duration, value);
        }

        public Double Maximun
        {
            get => this._maximun;
            set
            {
                if (value > 0)
                {
                    this.SetProperty(ref this._maximun, value);
                }
            }
        }

        public TimeSpan Position
        {
            get => this._position;
            set => this.SetProperty(ref this._position, value);
        }

        public bool IsPlaying
        {
            get => this._isPlaying;
            set => this.SetProperty(ref this._isPlaying, value);
        }

        public string PlayIcon => this.IsPlaying ? "pause" : "play";

        public bool IsPreview => this.MusicList.IndexOf(SelectedMusic) > 0;

        public bool IsNext => this.MusicList.IndexOf(SelectedMusic) < this.MusicList.Count-1;
        #endregion

        #region Commands
        public ICommand ChangeCommand => new Command(ChangeMusic);

        public ICommand ShareCommand => new Command(() => Share.RequestAsync(SelectedMusic.Url, SelectedMusic.Title));

        public ICommand PlayCommand => new Command(PlayMusic);

        public ICommand BackCommand => new Command(() => Application.Current.MainPage = new LandingPage());



        private void PlayMusic()
        {
            if (IsPlaying) this._audioPlayer.Pause();
            else this._audioPlayer.Play();
            
            IsPlaying = !IsPlaying;
        }

        private void ChangeMusic(object obj)
        {
            if (((string)obj).ToUpper().Equals("P"))
                PreviusMusic();
            if (((string)obj).ToUpper().Equals("N"))
                NextMusic();
        }

        private void NextMusic()
        {
            var currentMusic = MusicList.IndexOf(SelectedMusic);
            if (currentMusic < MusicList.Count - 1)
            {
                SelectedMusic = MusicList[currentMusic + 1];
                Play();
            }
        }

        private void PreviusMusic()
        {
            var currentMusic = MusicList.IndexOf(SelectedMusic);
            if (currentMusic > 0)
            {
                SelectedMusic = MusicList[currentMusic - 1];
                Play();
            }
        }

        private void Play()
        {
            var viewModel = new PlayerViewModel(SelectedMusic);
            var playerPage = new PlayerPage() { BindingContext = viewModel };

            Application.Current.MainPage = playerPage;
        }
        #endregion
    }
}
