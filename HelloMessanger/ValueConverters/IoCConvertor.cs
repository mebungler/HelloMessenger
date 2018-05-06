using HelloMessanger.Core;
using System;
using System.Diagnostics;
using System.Globalization;

namespace HelloMessanger
{
    public class IoCConvertor : BaseValueConverter<IoCConvertor>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((string)parameter)
            {
                case nameof(ApplicationViewModel):
                    return IoC.Get<ApplicationViewModel>();
                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
