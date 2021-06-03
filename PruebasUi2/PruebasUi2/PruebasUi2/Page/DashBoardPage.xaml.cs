using Microcharts;
using SkiaSharp;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebasUi2.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardPage : ContentPage
    {
        private List<Microcharts.Entry> ListEntry { get; }

        public DashBoardPage()
        {
            InitializeComponent();
            ListEntry = new List<Microcharts.Entry>();
            barChart.Chart = new BarChart() { Entries = ListEntry };
            pieChart.Chart = new RadialGaugeChart() { Entries = ListEntry };
            donutChart.Chart = new DonutChart() { Entries = ListEntry };
            linesChart.Chart = new LineChart() { Entries = ListEntry };
            pointChart.Chart = new PointChart() { Entries = ListEntry };
            radarChart.Chart = new RadarChart() { Entries = ListEntry };
            LoadEntries();
        }
        private void LoadEntries()
        {
            ListEntry.Add(new Microcharts.Entry(70)
            {
                Label = "Blue",
                ValueLabel = "70",
                Color = SKColor.Parse("#00bcd4")
            });
            ListEntry.Add(new Microcharts.Entry(300)
            {
                Label = "Red",
                ValueLabel = "300",
                Color = SKColor.Parse("#F44336")
            });
            ListEntry.Add(new Microcharts.Entry(50)
            {
                Label = "Green",
                ValueLabel = "50",
                Color = SKColor.Parse("#43A047")
            });
            ListEntry.Add(new Microcharts.Entry(500)
            {
                Label = "Orange",
                ValueLabel = "500",
                Color = SKColor.Parse("#F9A825")
            });
        }
    }
}