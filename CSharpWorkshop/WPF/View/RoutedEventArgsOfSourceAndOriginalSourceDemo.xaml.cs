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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF.View
{
    /// <summary>
    /// RoutedEventArgsOfSourceAndOriginalSourceDemo.xaml 的交互逻辑
    /// </summary>
    public partial class RoutedEventArgsOfSourceAndOriginalSourceDemo : Window
    {
        public RoutedEventArgsOfSourceAndOriginalSourceDemo()
        {
            InitializeComponent();
            //为主窗体添加对Button.Click事件的侦听
            this.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.Button_Click));
        }

        /// <summary>
        /// 路由事件处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            //Button.Click路由事件是从MyUserControl的innerButton发出来的，在主窗体中，myUserControl
            //是LogicalTree的末端结点，所以e.Source就是myUserControl:而窗体的VisualTree则包含了
            //myUserControl的内部结构，可以“看见”路由事件究竟是从哪个控件发出来的，所以使用Originalo可以获得innerButton。
            string strOriginalSource = string.Format("VisualTree start point:{0},type is {1}", (e.OriginalSource as FrameworkElement).Name, e.OriginalSource.GetType().Name);
            string strSource = string.Format("LogicalTree start point:{0},type is {1}", (e.Source as FrameworkElement).Name, e.Source.GetType().Name);
            MessageBox.Show(strOriginalSource + "\r\n" + strSource);
        }
    }
}
