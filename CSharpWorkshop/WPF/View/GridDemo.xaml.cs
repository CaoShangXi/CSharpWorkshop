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
    /// GridDemo.xaml 的交互逻辑
    /// </summary>
    public partial class GridDemo : Window
    {
        public GridDemo()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //#region 如果需要动态地调整Grid的布局，可以在C#完成对列和行的定义
            //#region 添加4列
            //this.gridMain.ColumnDefinitions.Add(new ColumnDefinition());
            //this.gridMain.ColumnDefinitions.Add(new ColumnDefinition());
            //this.gridMain.ColumnDefinitions.Add(new ColumnDefinition());
            //this.gridMain.ColumnDefinitions.Add(new ColumnDefinition());
            //#endregion

            //#region 添加3行
            //this.gridMain.RowDefinitions.Add(new RowDefinition());
            //this.gridMain.RowDefinitions.Add(new RowDefinition());
            //this.gridMain.RowDefinitions.Add(new RowDefinition());
            //#endregion
            //this.gridMain.ShowGridLines = true;
            //#endregion
        }
    }
}
