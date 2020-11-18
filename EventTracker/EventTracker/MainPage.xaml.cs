using EventTracker.Model;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace EventTracker
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Event> MyEvents => this.GetEvents();

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        private async void Expander_Tapped(object sender, EventArgs e)
        {
            var expander = sender as Expander;
            var imageView = expander.FindByName<Grid>("GridImageView");
            var details = expander.FindByName<Grid>("GridDetails");
            if (expander.IsExpanded) {
                await OpenAnimation(imageView);
                await OpenAnimation(details);
            }
            else {
                await CloseAnimation(imageView);
                await CloseAnimation(details);
            }
        }

        private ObservableCollection<Event> GetEvents()
        {
            return new ObservableCollection<Event> {
                new Event { Title = "Xamarin Forms Master Class", Image = "banner", Venue = "Registro Online", Duration = "07:30 UTC - 09:30 UTC", Date = DateTime.Now.AddDays(2) },
                new Event { Title = "Training: WDC Solution", Image = "onlinetraining", Venue = "Zoom Meeting", Duration = "07:30 UTC - 09:30 UTC", Date = DateTime.Now.AddDays(3) },
                new Event { Title = "World Dogs Championship", Image = "dogs", Venue = "Virtual Challenge", Duration = "07:30 UTC - 09:30 UTC", Date = DateTime.Now.AddDays(4) },
                new Event { Title = "Book Review Conference", Image = "bookclub", Venue = "Online", Duration = "07:30 UTC - 09:30 UTC", Date = DateTime.Now.AddDays(5) },
                new Event { Title = "Tea Ceremony", Image = "tea", Venue = "Virtual Meetup", Duration = "07:30 UTC - 09:30 UTC", Date = DateTime.Now.AddDays(6) },
            };
        }

        private async Task OpenAnimation(View view, uint length = 250)
        {
            view.RotationX = -90;
            view.IsVisible = true;
            view.Opacity = 0;
            await view.FadeTo(1, length);
            await view.RotateXTo(0, length);
        }

        private async Task CloseAnimation(View view, uint length = 250)
        {
            await view.FadeTo(0, length);
            await view.RotateXTo(-90, length);
            view.IsVisible = false;
        }
    }
}
