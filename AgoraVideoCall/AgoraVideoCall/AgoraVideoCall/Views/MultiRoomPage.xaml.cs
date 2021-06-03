using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AgoraVideoCall.ViewModels;

namespace AgoraVideoCall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiRoomPage : ContentPage
    {
        private MultiRoomViewModel _viewModel;

        public MultiRoomPage(MultiRoomViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = _viewModel = viewModel;
            _viewModel.Init();
        }

        public MultiRoomPage() : this(new MultiRoomViewModel("DesignTimeRoom"))
        {
        }

        protected override void OnDisappearing()
        {
            _viewModel.EndSessionCommand.Execute(false);
            base.OnDisappearing();
        }
    }
}