namespace PruebaUI3.ViewModel
{
    using PruebaUI3.Model;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class MenuViewModel: BaseViewModel
    {
        private ObservableCollection<Option> _options;
        private ObservableCollection<Option> _myTasks;
        private ObservableCollection<Option> _myMenu;

        public ObservableCollection<Option> MyTasks
        {
            get => this._myTasks;
            set => this.SetProperty(ref this._myTasks, value);
        }
        public ObservableCollection<Option> MyMenu
        {
            get => this._myMenu;
            set => this.SetProperty(ref this._myMenu, value);
        }
        public ObservableCollection<Option> Options
        {
            get => this._options;
            set => this.SetProperty(ref this._options, value);
        }

        public MenuViewModel()
        {
            this.Options = new ObservableCollection<Option>(new List<Option> {
                new Option { Image = "video", Text = "Record Youtube Video" },
                new Option { Image = "edit", Text = "Edit Video" },
                new Option { Image = "upload", Text = "Upload Video to Youtube" },
            });

            this.MyTasks = new ObservableCollection<Option>(new List<Option> {
                new Option { Image = "checkmark", Text = "Complete", Value = "25" },
                new Option { Image = "timelapse", Text = "In Progress", Value = "8" },
            });

            this.MyMenu = new ObservableCollection<Option>(new List<Option> {
                new Option { Image = "home", Text = "Home" },
                new Option { Image = "user", Text = "Profile" },
                new Option { Image = "bell", Text = "Notifications" },
                new Option { Image = "envelope", Text = "Messages" },
                new Option { Image = "tasks", Text = "My Tasks" },
            });
        }
    }
}
