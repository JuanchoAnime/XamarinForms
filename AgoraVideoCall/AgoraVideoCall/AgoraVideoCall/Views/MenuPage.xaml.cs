using AgoraVideoCall.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgoraVideoCall.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        private MainPage _rootPage { get => Xamarin.Forms.Application.Current.MainPage as MainPage; }

        private readonly List<HomeMenuItem> _menuItems;

        public MenuPage()
        {
            InitializeComponent();
            _menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Call, Title="Call" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" }
            };

            ListViewMenu.ItemsSource = _menuItems;
            ListViewMenu.SelectedItem = _menuItems[0];
            ListViewMenu.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var menuItemId = (int)((HomeMenuItem)e.SelectedItem).Id;
                _rootPage.NavigateFromMenu(menuItemId);
                ListViewMenu.SelectedItem = null;
            };
        }
    }
}