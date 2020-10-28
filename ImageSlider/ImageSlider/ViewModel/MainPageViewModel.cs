namespace ImageSlider.ViewModel
{
    using ImageSlider.Data;
    using ImageSlider.Model;
    using System.Collections.ObjectModel;

    public class MainPageViewModel
    {
        private ObservableCollection<ImageCarousel> _imageNodeInfo;

        public ObservableCollection<ImageCarousel> ImageNodeInfo 
        {
            get => this._imageNodeInfo;
            set { this._imageNodeInfo = value; }
        }

        public MainPageViewModel()
        {
            this.GenerateSource();
        }

        private void GenerateSource() 
        {
            var service = new ServiceData();
            this.ImageNodeInfo = new ObservableCollection<ImageCarousel>(service.FindAll());
        }
    }
}
