using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebaUI3.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void OpenAnimation() 
        {
            await SwipeContent.ScaleYTo(0.9, 300, Easing.SinOut);
            panckake.CornerRadius = 20;
            await SwipeContent.RotateTo(-15, 300, Easing.SinOut);
        }

        private void OpenSwipe(object sender, EventArgs e)
        {
            MainSwipeView.Open(OpenSwipeItem.LeftItems);
        }

        private async void CloseAnimation()
        {
            await SwipeContent.RotateTo(0, 300, Easing.SinOut);
            panckake.CornerRadius = 0;
            await SwipeContent.ScaleYTo(1, 300, Easing.SinOut);
        }

        private void CloseSwipe(object sender, EventArgs e)
        {
            MainSwipeView.Close();
            CloseAnimation();
        }

        private void SwipeStartedCommand(object sender, SwipeStartedEventArgs e)
        {
            OpenAnimation();
        }

        private void SwipeEndedCommand(object sender, SwipeEndedEventArgs e)
        {
            if(!e.IsOpen) CloseAnimation();
        }
    }
}