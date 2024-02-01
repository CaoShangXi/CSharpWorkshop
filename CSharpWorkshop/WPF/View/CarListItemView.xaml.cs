using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.Model;

namespace WPF.View
{
    /// <summary>
    /// CarListItemView.xaml 的交互逻辑
    /// </summary>
    public partial class CarListItemView : UserControl
    {
        public CarListItemView()
        {
            InitializeComponent();
        }

        private Car car;
        public Car Car
        {
            get
            {
                return car;
            }
            set
            {
                car = value;
                textBlockName.Text = car.Name;
                textBlockYear.Text = car.Year;
                string uriStr = string.Format(@"/Resources/Logos/{0}_logo.jpg",car.Automaker);
                imageLogo.Source = new BitmapImage(new Uri(uriStr,UriKind.Relative));
            }
        }
    }
}
