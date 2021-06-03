using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AgoraVideoCall.ViewModels;
using AgoraVideoCall.Views;

namespace AgoraVideoCall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnectPage : ContentPage
    {
        private readonly ConnectViewModel _viewModel;

        public ConnectPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ConnectViewModel();
            RoomName.Keyboard = Keyboard.Create(KeyboardFlags.None);
        }

        private void Handle_OneToOne_Clicked(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_viewModel.RoomName))
                Navigation.PushAsync(new RoomPage(new RoomViewModel(_viewModel.RoomName)));
        }

        private void Handle_Group_Clicked(object sender, System.EventArgs e)
        {/*
            if (!string.IsNullOrWhiteSpace(_viewModel.RoomName))
                Navigation.PushAsync(new MultiRoomPage(new MultiRoomViewModel(_viewModel.RoomName)));*/
        }
    }
}