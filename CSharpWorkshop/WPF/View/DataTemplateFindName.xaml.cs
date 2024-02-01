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

namespace WPF
{
    /// <summary>
    /// DataTemplateFindName.xaml 的交互逻辑
    /// </summary>
    public partial class DataTemplateFindName : Window
    {
        public DataTemplateFindName()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //DataTemplate派生自FrameworkTemplate类，这个类有个名为FindName的方法供我们检索其内部控件
            TextBlock tb = this.cp.ContentTemplate.FindName("textBlockName",this.cp) as TextBlock;
            MessageBox.Show(tb.Text);
            Student student=this.cp.Content as Student;
            MessageBox.Show(student.Name);
        }
    }
}
