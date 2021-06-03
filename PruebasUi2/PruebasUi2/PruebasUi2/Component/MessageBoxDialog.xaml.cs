using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;

namespace PruebasUi2.Component
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageBoxDialog : PopupPage
    {
        // This is true message dialog
        public MessageBoxDialog()
        {
            InitializeComponent();
        }
    }
}