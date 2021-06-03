namespace PruebasUi2.ViewModel
{
    public class MainViewModel
    {
        public static MainViewModel INSTANCE { get; set; }

        public MainViewModel()
        {
            INSTANCE = this;
        }

        public ProfileViewModel Profile { get; set; }

        public MoreViewModel More { get; set; }

        public MessageBoxViewModel MessageBox { get; set; }

        public LoginViewModel Login { get; set; }

        public MessageBoxDialogViewModel MessageBoxDialog { get; set; }

        public CarouselViewModel Carousel { get; set; }
    }
}
