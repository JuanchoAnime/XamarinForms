namespace PruebaUI.ViewModels
{
    public class MainViewModel
    {
        public static MainViewModel INSTANCE { get; set; }

        public MainViewModel()
        {
            INSTANCE = this;
        }

        public FIngerPrintViewModel FIngerPrint { get; set; }

        public FoodMainViewModel Food { get; set; }

        public FoodDetailViewModel FoodDetail { get; set; }

        public WheaterViewModel Wheater { get; set; }

        public TimerViewModel Timer { get; set; }
    }
}
