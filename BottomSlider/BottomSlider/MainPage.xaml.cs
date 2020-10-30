namespace BottomSlider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Plugin.DeviceOrientation;
    using Xamarin.Essentials;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (MyDraggableView.Height == 0) {

                var mainDisplay = DeviceDisplay.MainDisplayInfo;
                double endHeigth = mainDisplay.Height / 5;
                Action<double> callback = callback = input => MyDraggableView.HeightRequest = input;
                Animation(callback, 0, endHeigth, 3, Easing.CubicOut);
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (MyDraggableView.Height != 0)
            {
                var mainDisplay = DeviceDisplay.MainDisplayInfo;
                double strartHeigth = mainDisplay.Height / 5;
                Action<double> callback = callback = input => MyDraggableView.HeightRequest = input; ;
                Animation(callback, strartHeigth, 0, 32, Easing.SinOut);
            }
        }

        private void Animation(Action<double> callback, double strartHeigth, double endHeigth, 
            uint rate, Easing easing)
        {
            uint length = 500;
            MyDraggableView.Animate("anim", callback, strartHeigth, endHeigth, rate, length, easing);
        }
    }
}
