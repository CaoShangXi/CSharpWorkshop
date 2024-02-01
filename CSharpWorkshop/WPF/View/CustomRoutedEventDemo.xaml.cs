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
    /// 自定义路由事件演示
    /// </summary>
    public partial class CustomRoutedEventDemo : Window
    {
        public CustomRoutedEventDemo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Report TimeEvent路由事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportTimeHandler(object sender, ReportTimeEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            string timeStr = e.ClickTime.ToLongTimeString();
            string content = string.Format("{0} {1}", timeStr, element.Name);
            this.listBox.Items.Add(content);
            //RoutedEventArgs类具有一个bool类型属性Handled,一旦这个属性被设置为true,
            //就表示路由事件“已经被处理”了(Handle有“处理”、“搞定”的意思)，那么路由事件也就不必
            //再往下传递了。
            if (element==this.grid_2)
            {
                e.Handled = true;
            }
        }
    }
}
