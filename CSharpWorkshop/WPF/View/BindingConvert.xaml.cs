using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Linq;
using WPF.Common;
using WPF.Model;

namespace WPF.View
{
    /// <summary>
    /// BindingConvert.xaml 的交互逻辑
    /// </summary>
    public partial class BindingConvert : Window
    {
        public BindingConvert()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Plane p in listBoxPlane.Items)
            {
                sb.AppendLine(string.Format("Category={0},Name={1},State={2}", p.Category, p.Name, p.State));
                File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PlaneList.txt"), sb.ToString());
            }
        }

        private void buttonLoad_Click(object sender, RoutedEventArgs e)
        {
            List<Plane> planeList = new List<Plane> {
            new Plane{Category = Category.Bomber,Name = "B-1", State = State.Unknown},
            new Plane{Category= Category.Bomber,Name = "B-2",State = State.Unknown },
            new Plane{Category= Category.Fighter,Name = "F-22",State = State.Unknown },
            new Plane{Category= Category.Fighter,Name = "Su-47",State = State.Unknown },
            new Plane{Category= Category.Bomber, Name="B-52", State= State.Unknown },
            new Plane{Category= Category.Fighter, Name= "J-10",State=State.Unknown},
    };
            listBoxPlane.ItemsSource = planeList;
        }
    }
}
