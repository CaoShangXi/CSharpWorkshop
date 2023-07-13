using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using WpfTemplateDemo.Model;

namespace WpfTemplateDemo.Common
{
    /// <summary>
    /// 厂商名称转换为Logo图片路径
    /// </summary>
    public class AutomakerToLogoPathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string uriStr = string.Format(@"/Resources/Logos/{0}_logo.jpg", (string)value);
            return new BitmapImage(new Uri(uriStr, UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
