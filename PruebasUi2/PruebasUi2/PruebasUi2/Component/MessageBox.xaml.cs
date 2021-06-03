using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;

namespace PruebasUi2.Component
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MessageBox : PopupPage
    {
        public MessageBox()
        {
            //Install Rg Popup, this is loading fragment
            InitializeComponent();
        }
    }
}