namespace AnimateText
{
    using AnimateText.Model;
    using System;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Badge> _badges;
        private float _amount;

        public ObservableCollection<Badge> Badges 
        {
            get => this._badges;
            set  {
                this._badges = value;
                OnPropertyChanged();
            }
        }

        public float Amount
        {
            get => this._amount;
            set
            {
                this._amount = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
            this.Badges = GetBadgets();
        }

        private ObservableCollection<Badge> GetBadgets()
        {
            return new ObservableCollection<Badge> {
                new Badge { Name = "Food", Amount = 650, Color = Color.Blue, Image = "food" },
                new Badge { Name = "Groceries", Amount = 1350, Color = Color.SlateBlue, Image = "grocery" },
                new Badge { Name = "Transport", Amount = 170, Color = Color.Purple, Image = "transport" },
                new Badge { Name = "Utilies", Amount = 750, Color = Color.PeachPuff, Image = "utilities.png" },
            };
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Amount = 0.0f;
            var grid = sender as Grid;
            var parent = grid.Parent as StackLayout;

            ((parent.Parent) as ScrollView).ScrollToAsync(grid, ScrollToPosition.MakeVisible, true);

            foreach (var item in parent.Children)
            {
                var bg = item.FindByName<BoxView>("MainBig");
                var details = item.FindByName<StackLayout>("DetailsView");
                details.TranslateTo(-40, 0, 200, Easing.SinInOut);
                bg.IsVisible = false;
                details.IsVisible = false;

                var sBg = grid.FindByName<BoxView>("MainBig");
                var sdetails = grid.FindByName<StackLayout>("DetailsView");
                sBg.IsVisible = true;
                sdetails.IsVisible = true;
                sdetails.TranslateTo(0, 0, 30, Easing.SinInOut);
                AnimatedText((grid.BindingContext as Badge).Amount);
             }
        }

        private void AnimatedText(float amount)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Device.StartTimer(TimeSpan.FromSeconds(1 / 100f), () => {
                double t = stopWatch.Elapsed.TotalMilliseconds % 500 / 500;
                Amount = Math.Min((float)amount, (float)(10 * t) + Amount);
                if (Amount >= amount) {
                    stopWatch.Stop();
                    return false;
                }
                return true;
            });
        }
    }
}
