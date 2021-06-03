using AgoraVideoCall.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgoraVideoCall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoomPage : ContentPage
    {
        private readonly RoomViewModel viewModel;

        public RoomPage(RoomViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
            viewModel.Init();
        }

        public RoomPage() : this(new RoomViewModel("DesignTimeRoom"))
        {

        }

        protected override void OnDisappearing()
        {
            viewModel.EndSessionCommand.Execute(false);
            base.OnDisappearing();
        }
    }
}