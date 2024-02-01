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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.Model;
using WPF.View;

namespace WPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitialCarList();
        }

        /// <summary>
        /// 初始化ListBox
        /// </summary>
        public void InitialCarList()
        {
            List < Car > carList=new List<Car> { 
            new Car{Automaker="Benz",Name="奔驰",Year="1990",TopSpeed="360"},
            new Car{Automaker="Audi",Name="奥迪",Year="1899",TopSpeed="365"},
            new Car{Automaker="Volkswagen",Name="大众",Year="1950",TopSpeed="330"},
            new Car{Automaker="BYD",Name="比亚迪",Year="2000",TopSpeed="350"},
            };
            listBoxCars.ItemsSource = carList;
        }
    }
}
