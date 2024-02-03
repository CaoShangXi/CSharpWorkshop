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
using System.Windows.Shapes;
using WPF.Model;

namespace WPF.View
{
    /// <summary>
    /// XamlTypeConverter.xaml 的交互逻辑
    /// </summary>
    public partial class XamlTypeConverter : Window
    {
        public XamlTypeConverter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Human h=(Human)this.FindResource("human");
            MessageBox.Show(string.Format("姓名：{0}，后代姓名：{1}",h.Name,h.Child.Name));
        }
    }
}
