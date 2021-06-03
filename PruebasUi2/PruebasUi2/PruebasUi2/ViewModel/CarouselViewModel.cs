using PruebasUi2.ItemViewModel;
using System.Collections.ObjectModel;

namespace PruebasUi2.ViewModel
{
    // nuget carouselview
    public class CarouselViewModel : BaseViewModel
    {
        public ObservableCollection<WalkthroughItemViewModel> WalkthroughItems { get => Load(); }

        private ObservableCollection<WalkthroughItemViewModel> Load()
        {
            return new ObservableCollection<WalkthroughItemViewModel>(new[]
            {
                new WalkthroughItemViewModel
                {
                    Heading ="Mountains",
                    Caption = "Explore the world from your own point of view. Visit mountains and enjoy the freshness of life.",
                    Image = "mountains.png"
                },

                new WalkthroughItemViewModel
                {
                    Heading ="Cities",
                    Caption = "Experience the blue and grey sights of high rise buildings around the world",
                    Image = "Cities.png"
                },

                new WalkthroughItemViewModel
                {
                    Heading ="Ancient",
                    Caption = "Understand the history and heritage of different cultures around the world.",
                    Image = "Ancient.png"
                }
            });
        }
    }
}
