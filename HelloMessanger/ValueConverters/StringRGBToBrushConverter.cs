using System;
using System.Globalization;
using System.Diagnostics;
using System.Windows.Media;

namespace HelloMessanger
{
    /// <summary>
    /// Converts <see cref="ApplicationPage"></see> to an actual view/page
    /// </summary>
    public class StringRGBToBrushConverter : BaseValueConverter<StringRGBToBrushConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (SolidColorBrush)(new BrushConverter().ConvertFrom($"#{value}"));
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
