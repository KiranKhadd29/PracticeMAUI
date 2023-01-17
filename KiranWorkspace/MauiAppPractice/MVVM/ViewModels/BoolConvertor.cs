using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppPractice.MVVM.ViewModels
{
    public class BoolConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string married = value.ToString();
            if (married == "Married")
            {
                return true;
            }
            return false;
        }
         
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolean =  (bool)value;
            if(boolean)
            {
                return "Married";
            }
            return "Not Married";
        }
    }
}
