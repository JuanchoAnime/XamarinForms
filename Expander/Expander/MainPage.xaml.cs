namespace Expander
{
    using Expander.Model;
    using System;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Agenda> MyAgenda => getAgendas();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private ObservableCollection<Agenda> getAgendas()
        {
            return new ObservableCollection<Agenda>() {
                new Agenda{
                    Color = "#896CBD",
                    Topic = "All Things Xamarin",
                    Duration = "07:30 - 11:30",
                    Date = DateTime.Now.AddDays(1),
                    Speakers = new ObservableCollection<Speaker>{ 
                        new Speaker { Name = "Maddy Leger", Time = "07:30" }, 
                        new Speaker { Name = "David Ortinau", Time = "08:30" }, 
                        new Speaker { Name = "Gerald Versluis", Time = "10:30" } 
                    },
                },
                new Agenda { 
                    Topic = "Visualize Your Data", 
                    Duration = "07:30 UTC - 11:30 UTC", 
                    Color = "#49A24D", 
                    Date = DateTime.Now.AddDays(2),
                    Speakers = new ObservableCollection<Speaker>{ 
                        new Speaker { Name = "Maddy Leger", Time = "07:30" }, 
                        new Speaker { Name = "David Ortinau", Time = "08:30" }, 
                        new Speaker { Name = "Gerald Versluis", Time = "10:30" } } 
                },
                new Agenda { 
                    Topic = "Testing Your Xamarin Apps", 
                    Duration = "07:30 UTC - 11:30 UTC", 
                    Color = "#FDA838", 
                    Date = DateTime.Now.AddDays(3),
                    Speakers = new ObservableCollection<Speaker>{ 
                        new Speaker { Name = "Maddy Leger", Time = "07:30" }, 
                        new Speaker { Name = "David Ortinau", Time = "08:30" }, 
                        new Speaker { Name = "Gerald Versluis", Time = "10:30" } } 
                },
                new Agenda { 
                    Topic = "Xamarin Productivity to the Max", 
                    Duration = "07:30 UTC - 11:30 UTC", 
                    Color = "#F75355", 
                    Date = DateTime.Now.AddDays(4),
                    Speakers = new ObservableCollection<Speaker>{ 
                        new Speaker { Name = "Maddy Leger", Time = "07:30" }, 
                        new Speaker { Name = "David Ortinau", Time = "08:30" }, 
                        new Speaker { Name = "Gerald Versluis", Time = "10:30" } } 
                },
                new Agenda { 
                    Topic = "All Things Xamarin.Forms Shell", 
                    Duration = "07:30 UTC - 11:30 UTC", 
                    Color = "#00C6AE",
                    Date = DateTime.Now.AddDays(5),
                    Speakers = new ObservableCollection<Speaker>{ 
                        new Speaker { Name = "Maddy Leger", Time = "07:30" }, 
                        new Speaker { Name = "David Ortinau", Time = "08:30" }, 
                        new Speaker { Name = "Gerald Versluis", Time = "10:30" } } 
                },
                new Agenda { 
                    Topic = "Building Beautiful Apps", 
                    Duration = "07:30 UTC - 11:30 UTC", 
                    Color = "#455399", 
                    Date = DateTime.Now.AddDays(6),
                    Speakers = new ObservableCollection<Speaker>{ 
                        new Speaker { Name = "Maddy Leger", Time = "07:30" }, 
                        new Speaker { Name = "David Ortinau", Time = "08:30" }, 
                        new Speaker { Name = "Gerald Versluis", Time = "10:30" } } 
                }
            };
        }

    }
}
