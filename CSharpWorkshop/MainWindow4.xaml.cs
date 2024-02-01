using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfNetDemo
{
    /// <summary>
    /// MainWindow4.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow4 : Window
    {
        public ObservableCollection<Table> Tables { get; set; } = new ObservableCollection<Table>
{
    new Table { Name = "Table1", Children = new ObservableCollection<Table> { new Table{Name="111" } } },
    new Table { Name = "Table2", Children = new ObservableCollection<Table> { new Table { Name = "222" } } }
};
        public MainWindow4()
        {
            InitializeComponent();

            //treeView.DataContext = Tables;
        }
    }

    public class Table
    {
        public string Name { get; set; }
        public ObservableCollection<Table> Children { get; set; }
    }

}
