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
using WpfTemplateDemo.Model;

namespace WpfTemplateDemo.View
{
    /// <summary>
    /// 绑定演示
    /// </summary>
    public partial class BindingDemo : Window
    {
        private Student stu;
        public BindingDemo()
        {
            InitializeComponent();
            //准备数据源
            //stu = new Student();
            //准备Binding
            //Binding binding = new Binding();
            //binding.Source = stu;
            //Binding指定访问路径
            //binding.Path = new PropertyPath("Name");
            //使用Binding连接数据源与Binding目标
            //第一个参数用于指定Binding的目标，本例中是this.textBoxName。
            //与数据源的Path原理类似，第二个参数用于为Binding指明把数据送达目标的哪个属性。
            //只是你会发现在这里用的不是对象的属性而是类的一个静态只读(staticeadony)的
            //DependeneyProperty类型成员变量！这就是我们后面要详细讲述的与Binding息息相关的
            //依赖属性。其实很好理解，这类属性的值可以通过Binding依赖在其他对象的属性值上，
            //被其他对象的属性值所驱动。
            //第三个参数很明了，就是指定使用哪个Binding实例将数据源与目标关联起来。
            //BindingOperations.SetBinding(this.textBoxName, TextBox.TextProperty, binding);
            //下面语法的作用是相同的
            textBoxName.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu = new Student() });

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //对数据源进行更新，UI层也自动更新
            stu.Name += "Name";
        }
    }
}
