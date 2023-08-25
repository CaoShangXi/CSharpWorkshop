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

namespace WpfTemplateDemo.View
{
    /// <summary>
    /// ResourcesDemo.xaml 的交互逻辑
    /// </summary>
    public partial class ResourcesDemo : Window
    {
        public ResourcesDemo()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string text=(string)this.FindResource("str");
            string text1=(string)Resources["str"];
            Console.WriteLine(text1);
            Console.WriteLine(text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resources["res1"] = new TextBlock { Text="天涯共此时"};
            Resources["res2"] = new TextBlock { Text = "天涯共此时"};
        }
    }
}
