using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ChangeVisibilityOfButtonFromCodeMVVN.Converter
{
    public class NaviButtonShowOrNot : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Uri uri = new Uri(value.ToString());
            if (uri != null)
            {
                if (uri.Equals("ms-appx:///MainPage.xaml"))
                {
                    return Visibility.Collapsed;
                }
            }
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}