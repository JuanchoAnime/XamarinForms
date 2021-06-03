namespace PruebaUI.ViewModels
{
    using PruebaUI.Models;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;
    public class TimerViewModel : BaseViewModel
    {
        private ObservableCollection<EventModel> _eventModels;

        public ObservableCollection<EventModel> EventModels
        {
            get => this._eventModels;
            set => this.SetProperty(ref this._eventModels, value);
        }

        public TimerViewModel()
        {
            List<EventModel> list = new List<EventModel> {
                new EventModel{ Title = "Camping", BgColor = "#EB9999", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(12, 23, 45, 59).Ticks)},
                new EventModel{ Title = "Tony's Wedding", BgColor = "#96338F", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(270, 1, 22, 10).Ticks)},
                new EventModel{ Title = "Hackathon", BgColor = "#8251AE", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(48, 11, 15, 0).Ticks)},
                new EventModel{ Title = "Exams", BgColor = "#6787FF", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(2, 17, 29, 45).Ticks)},
            };

            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                list.ForEach(evt =>
                    evt.Time = evt.Date - DateTime.Now
                );
                return true;
            });
            this.EventModels = new ObservableCollection<EventModel>(list);
        }
    }
}
