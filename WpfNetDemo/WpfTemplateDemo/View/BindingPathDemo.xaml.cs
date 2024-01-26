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
    /// BindingPathDemo.xaml 的交互逻辑
    /// </summary>
    public partial class BindingPathDemo : Window
    {
        public BindingPathDemo()
        {
            InitializeComponent();
            string myString = "菩提本无树，明镜亦非台。本来无一物，何处惹尘埃。";
            this.textBlock1.SetBinding(TextBlock.TextProperty,new Binding(".") { Source=myString});
        }
    }
}
