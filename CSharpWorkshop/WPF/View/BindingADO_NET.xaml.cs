using System;
using System.Collections.Generic;
using System.Data;
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
    /// BindingADO_NET.xaml 的交互逻辑
    /// </summary>
    public partial class BindingADO_NET : Window
    {
        public BindingADO_NET()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt= new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Rows.Add(1,"Tim",29);
            dt.Rows.Add(2,"Tom",28);
            dt.Rows.Add(3,"Tony",27);
            dt.Rows.Add(4,"kyle",26);
            dt.Rows.Add(5,"Vina",25);
            dt.Rows.Add(6,"Emily",24);
            listBoxStudents.DisplayMemberPath = "Name";
            //DataView类实现了IEnumerable接口，所以可以被赋值给ListBox.ItemsSource属性。
            //listBoxStudents.ItemsSource = dt.DefaultView;
            //当你把一个DataTable对象放在一个对象的DataContext属性里，并把ItemsSource与一个既没有指定Source又没有指定Path的Binding关联起来时，Binding却能自动找到它的DefaultView并当作自己的Source来使用。
            this.listBoxStudents.DataContext = dt;
            this.listBoxStudents.SetBinding(ListView.ItemsSourceProperty,new Binding("."));
        }
    }
}
