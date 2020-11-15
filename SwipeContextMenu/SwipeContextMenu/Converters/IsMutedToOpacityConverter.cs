namespace SwipeContextMenu.Converters
{
    using System;
    using System.Globalization;
    using Xamarin.Forms;

    public class IsMutedToOpacityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isMuted) {
                var result = isMuted ? .6 : 1;
                return result;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) { throw new NotImplementedException(); }
    }
}
