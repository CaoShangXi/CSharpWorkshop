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

namespace WpfNetDemo
{
    /// <summary>
    /// MainWindow3.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow3 : Window
    {
        public MainWindow3()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Company> ManufacturerList = new List<Company>();

            ManufacturerList.Add(new Company()
            {
                Task = "Coding",
                DurationTotal = "4",
                HeadNote = "Coding Task",
                Models = new List<Model>(){
                    new Model(){SubTask = "Write", Duration = "2", Notes ="It pays the bills" },
                    new Model(){SubTask = "Compile", Duration = "1", Notes ="c# or go home" },
                    new Model(){SubTask = "Test", Duration = "1", Notes ="works on my m/c" },}
            });

            ManufacturerList.Add(new Company()
            {
                Task = "Communicate",
                DurationTotal = "2",
                HeadNote = "Communication Task",
                Models = new List<Model>(){
                    new Model(){SubTask = "Email", Duration = "0.5", Notes ="so much email work"  },
                    new Model(){SubTask = "Blogs", Duration = "0.25", Notes ="blogs.msdn.com/delay" },
                    new Model(){SubTask = "Twitter", Duration = "0.25", Notes ="RT:nothing to report" },}
            });
            treeviewList.ItemsSource = ManufacturerList;
        }
    }

    public class Company
    {
        public string Task { get; set; }
        public string DurationTotal { get; set; }
        public string HeadNote { get; set; }
        public List<Model> Models { get; set; }
    }
    public class Model
    {
        public string SubTask { get; set; }
        public string Duration { get; set; }
        public string Notes { get; set; }
    }
}
