namespace XamGMaps
{
    using System;
    using System.IO;
    using System.Reflection;
    using Xamarin.Forms;
    using Xamarin.Forms.GoogleMaps;
    using XamGMaps.ViewModel;

    public partial class MainPage : ContentPage
    {
        MapPageViewModel viewModel;
        public MainPage()
        {
            BindingContext = viewModel = new MapPageViewModel();
            InitializeComponent();
            ApplyMapTheme();
        }

        private void ApplyMapTheme()
        {
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream($"XamGMaps.MapResources.MapTheme.json");
            string themeFile;
            using (var reader = new StreamReader(stream))
            {
                themeFile = reader.ReadToEnd();
                gmap.MapStyle = MapStyle.FromJson(themeFile);
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var contents = await viewModel.Vehicles();
            if (contents != null)
            {
                contents.ForEach(v =>
                {
                    gmap.Pins.Add(new Pin()
                    {
                        Type = PinType.Place,
                        Icon = (Device.RuntimePlatform == Device.Android)
                            ? BitmapDescriptorFactory.FromBundle("CarPins.png")
                            : BitmapDescriptorFactory.FromView(new Image() { Source = "iconfinder.png", WidthRequest = 20, HeightRequest = 20 }),
                        Label = v.Desc,
                        Rotation = 50,
                        Tag = "Estación del Portal",
                        Address = "Sunida-ku Tokyo, Japan",
                        Position = new Position(v.Latitude, v.Longitud),
                    });
                });
                var miPosition = new Position(10.375917, -75.459776);
                gmap.Pins.Add(new Pin()
                {
                    Type = PinType.Place,
                    Label = "You",
                    Rotation = 50,
                    Position = miPosition,
                });
                gmap.MoveToRegion(MapSpan.FromCenterAndRadius(miPosition, Distance.FromMeters(500)));
            }
        }
    }
}
