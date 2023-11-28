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
    /// DependencyProperty.xaml 的交互逻辑，依赖属性的演示
    /// </summary>
    public partial class DependencyProperty : Window
    {
        public DependencyProperty()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student stu=new Student();
            ////存取依赖属性的值
            //stu.SetValue(Student.NameProperty,this.textBox1.Text);
            ////获取依赖属性的值
            //textBox2.Text=(string)stu.GetValue(Student.NameProperty);

            //stu.Name = this.textBox1.Text;
            //textBox2.Text= stu.Name;

            //stu的Name属性绑定textBox1的Text属性
            stu.SetBinding(Student.NameProperty,new Binding("Text") {Source=textBox1 });
            //textBox2的Text属性绑定stu的Name属性
            textBox2.SetBinding(TextBox.TextProperty,new Binding("Name") { Source=stu});
        }
    }
}
