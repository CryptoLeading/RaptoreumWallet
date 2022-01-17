using RaptoreumWallet.Common.Styles;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace RaptoreumWallet.Converters
{
    public class ChipColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int intValue)
            {
                switch ((intValue - 1) % 3)
                {
                    case 0: return Colors.BlueColor;
                    case 1: return Colors.GreenColor;
                    case 2: return Colors.OrangeColor;
                }
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
