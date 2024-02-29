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
    /// TypeDemo.xaml 的交互逻辑
    /// </summary>
    public partial class TypeDemo : Window
    {
        public TypeDemo()
        {
            InitializeComponent();

            List<Employee> empList = new List<Employee> {
            new Employee{Id=1,Name="Tim",Age=30 },
            new Employee{Id=2,Name="Tom",Age=26},
            new Employee{Id=3,Name="Guo",Age=26 },
            new Employee{Id=4,Name="Yan",Age=25},
            new Employee{ Id = 5, Name = "Owen", Age = 30 },
            new Employee{Id = 6, Name = "Victor", Age = 30},
            };
            //DisplayMemberPath这个属性告诉ListBox显示每条数据的哪个属性，换句话说，ListBox会去
            //调用这个属性值的ToString()方法，把得到的字符串放入一个TextBlock(最简单的文本控件)，然
            //后再按前面说的办法把TextBlock包装进一个ListBoxItem里。
            //ListBox的Selected ValuePath属性将与其SelectedValue属性配合使用。当你调用SelectedValue
            //属性时，ListBox先找到选中的Item所对应的数据对象，然后把SelectedValuePath的值当作数据对
            //象的属性名称并把这个属性的值取出来。
            //DisplayMemberPath和SelectedValuePath是两个相当简化的属性，DisplayMemberPath只能显示
            //简单的字符串，想用更加复杂的形式显示数据需要使用DataTemplate,我们在后面的章节详细讨论：
            //SelectedValuePath也只能返回单一的值，如果想进行一些复杂的操作，不妨直接使用ListBox的
            //SelectedItem和SelectedItems属性，这两个属性返回的就是数据集合中的对象，得到原始的数据对
            //象后就任由程序员操作了。
            this.listBoxEmplyee.DisplayMemberPath = "Name";
            this.listBoxEmplyee.SelectedValuePath = "Id";
            this.listBoxEmplyee.ItemsSource = empList;
        }

        private void buttonVictor_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            DependencyObject level1 = VisualTreeHelper.GetParent(btn);
            DependencyObject level2 = VisualTreeHelper.GetParent(level1);
            DependencyObject level3 = VisualTreeHelper.GetParent(level2);
            MessageBox.Show(level3.GetType().ToString());
        }
    }
}
