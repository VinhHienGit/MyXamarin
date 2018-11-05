using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace LayoutEx
{
    public class MultiTriggerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int n =-1;
            if (value.Equals(""))
                return false;
            int.TryParse(value.ToString().Trim(), out n); // check isNumer value input 
            if (n >= 0 && n <=255) //Color RGB value: 0--->255
                return true;        
            else
                return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
