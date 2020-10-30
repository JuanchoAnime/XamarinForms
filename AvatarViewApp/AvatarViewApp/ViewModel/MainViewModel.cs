namespace AvatarViewApp.ViewModel
{
    using AvatarViewApp.Model;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    public class MainViewModel: BindableObject
    {
        private ObservableCollection<Contact> _contentItemsCollection;

        public ObservableCollection<Contact> ContentItemsCollection
        {
            get => this._contentItemsCollection;
            set {
                this._contentItemsCollection = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            ContentItemsCollection = new ObservableCollection<Contact>
            {
              new Contact{Name ="AK", Avatar = "UserImage2" ,PhoneNumber = "+956-23234355" },
              new Contact{Name ="BR", Avatar = "", PhoneNumber = "+656-232343678"},
              new Contact{Name ="CT", Avatar = "UserImg",PhoneNumber = "+126-23234355"},
              new Contact{Name ="DA", Avatar= "",PhoneNumber = "+3456-23234355"},
              new Contact{Name ="EL", Avatar= "UserImg3",PhoneNumber = "+546-232346467"},
              new Contact{Name ="FR", Avatar= "UserImg4",PhoneNumber = "+54656-23239955"},
              new Contact{Name ="GR", Avatar= "UserImg5",PhoneNumber = "+4645-2089234355"},
              new Contact{Name ="HW", Avatar= "",PhoneNumber = "+4566-2323870355"},
              new Contact{Name ="IL", Avatar= "",PhoneNumber = "+4656-23234355"},
              new Contact{Name ="JW", Avatar= "",PhoneNumber = "+57656-2323478955"},
              new Contact{Name ="KT", Avatar= "",PhoneNumber = "+6566-2323477955"},
              new Contact{Name ="TA", Avatar= "UserImg6",PhoneNumber = "+454756-23234355"},
            };
        }
    }
}
