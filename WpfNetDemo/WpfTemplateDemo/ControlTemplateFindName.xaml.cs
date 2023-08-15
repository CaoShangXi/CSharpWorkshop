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

namespace WpfTemplateDemo
{
    /// <summary>
    /// ControlTemplateFindName.xaml 的交互逻辑
    /// </summary>
    public partial class ControlTemplateFindName : Window
    {
        public ControlTemplateFindName()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ControlTemplate和DataTemplate两个类均派生自FrameworkTemplate类，这个类有个名为FindName的方法供我们检索其内部控件
            TextBox tb =this.uc.Template.FindName("textBox1", this.uc) as TextBox;
            tb.Text = "Hello WPF";
            StackPanel sp=tb.Parent as StackPanel;
            (sp.Children[1] as TextBox).Text = "Hello ControlTemplate";
            (sp.Children[2] as TextBox).Text = "I can find you!";
        }
    }
}
