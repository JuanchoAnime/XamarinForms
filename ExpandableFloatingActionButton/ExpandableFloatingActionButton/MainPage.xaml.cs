using ExpandableFloatingActionButton.Model;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ExpandableFloatingActionButton
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Album> MyImages { get; set; }

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
            //this.MyImages = GetImages();
        }

        private ObservableCollection<Album> GetImages()
        {
            throw new NotImplementedException();
        }
    }
}
