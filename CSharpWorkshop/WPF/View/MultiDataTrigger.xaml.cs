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
    /// MultiDataTrigger.xaml 的交互逻辑
    /// </summary>
    public partial class MultiDataTrigger : Window
    {
        public MultiDataTrigger()
        {
            InitializeComponent();
            DataContext = new List<Student> {
            new Student{
            Id=1,
            Name="Jack",
            },
            new Student{
            Id=2,
            Name="Tom",
            },
            new Student{
            Id=3,
            Name="Bob",
            },
            };
        }
    }
}
