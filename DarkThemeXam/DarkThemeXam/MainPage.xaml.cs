using System.Collections.Generic;
using Xamarin.Forms;
using DarkThemeXam.Themes;

namespace DarkThemeXam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new LightTheme());
            }
        }

        void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new DarkTheme());
            }
        }
    }
}
