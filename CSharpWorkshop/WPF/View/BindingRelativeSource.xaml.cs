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

namespace WPF.View
{
    /// <summary>
    /// BindingRelativeSource.xaml 的交互逻辑
    /// </summary>
    public partial class BindingRelativeSource : Window
    {
        public BindingRelativeSource()
        {
            InitializeComponent();
            //RelativeSource rs = new RelativeSource(RelativeSourceMode.FindAncestor);
            //rs.AncestorLevel = 1;
            //rs.AncestorType = typeof(Grid);
            //Binding binding = new Binding("Name") { RelativeSource = rs };
            //this.textBox1.SetBinding(TextBox.TextProperty, binding);

            //RelativeSource rs = new RelativeSource();
            //AncestorLevel属性指的是以Binding目标控件为起点的层级偏移量一d2的偏移量是I、g2
            //的偏移量为2，依次类推。AncestorType属性告诉Binding寻找哪个类型的对象作为自己的源，不
            //是这个类型的对象会被跳过。上面这段代码的意思是告诉Binding从自己的第一层依次向外找，找
            //到第一个Gid类型对象后把它当作自己的源。运行效果如图6 - 28所示。
            //rs.AncestorLevel = 2;
            //rs.AncestorType = typeof(DockPanel);//查找指定类型上级
            //Binding binding = new Binding("Name") { RelativeSource = rs };
            //this.textBox1.SetBinding(TextBox.TextProperty, binding);

            //控件关联自己的Name属性
            RelativeSource rs = new RelativeSource(RelativeSourceMode.Self);
            Binding binding = new Binding("Name") { RelativeSource = rs };
            this.textBox1.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
