using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace WPF_LibraryManagement
{
    public class BoolToVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is bool && values[1] is bool)
            {
                bool hasText = !(bool)values[0];
                bool hasFocus = (bool)values[1];

                if (hasFocus || hasText)
                    return Visibility.Collapsed;
            }

            return Visibility.Visible;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ReaderStatus : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "0":
                    return System.Windows.Media.Colors.PaleVioletRed;
                case "1":
                    return System.Windows.Media.Colors.MediumSeaGreen;
            }
            return System.Windows.Media.Colors.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class DecadeBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string obj = value as String;
            switch (obj)
            {
                case "C01":
                    return new SolidColorBrush(Colors.DarkBlue);
                case "C02":
                    return new SolidColorBrush(Colors.DarkGray);
                case "C03":
                    return new SolidColorBrush(Colors.DarkGreen);
                case "C04":
                    return new SolidColorBrush(Colors.DarkOrange);
            }
            return new SolidColorBrush(Colors.DarkCyan); 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
