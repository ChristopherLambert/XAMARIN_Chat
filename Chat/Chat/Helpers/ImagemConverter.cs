using System;
using System.IO;
using Xamarin.Forms;

namespace Chat.Helpers
{
    public class ImagemConverter : IValueConverter
    {
        ImageSource ConvertImage(string base64) => ImageSource.FromStream(() => new MemoryStream(System.Convert.FromBase64String(base64)));

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return "";
            return ConvertImage(value.ToString());
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return "";
            return ConvertImage(value.ToString());
        }
    }
}
