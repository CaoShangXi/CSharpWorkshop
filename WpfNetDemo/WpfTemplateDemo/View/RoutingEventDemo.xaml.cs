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

namespace WpfTemplateDemo.View
{
    /// <summary>
    /// 路由事件
    /// </summary>
    public partial class RoutingEvent : Window
    {
        public RoutingEvent()
        {
            InitializeComponent();
            //该方法与在XAML声明的属性作用相同
            //this.gridRoot.AddHandler(Button.ClickEvent,new RoutedEventHandler(ButtonClicked));
        }

        public void ButtonClicked(object sender,RoutedEventArgs args)
        {
            //当按钮被单击时，Button.CIick事件就会沿着buttonLeft一canvasLeft-→gridA→girdRoot-→
            //Window这条路线向上传送；单击buttonRight,.则Button..Click事件沿着buttonRight一→canvasRight
            //gidA→gridRoot -→Window路线传送。
            MessageBox.Show((args.OriginalSource as FrameworkElement).Name);
        }

        // 可视化树
        StringBuilder visual = new StringBuilder();
        string GetVisualTree(int depth, DependencyObject obj)
        {
            visual.Append($"{new string(' ', depth)}{obj.GetType().Name}\n");

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                GetVisualTree(depth + 1, VisualTreeHelper.GetChild(obj, i));
            }
            return visual.ToString();
        }
        private void ButtonVisual_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(GetVisualTree(0, this), "可视化树", MessageBoxButton.OK, MessageBoxImage.Question);
        }


        // 逻辑树
        StringBuilder logical = new StringBuilder();
        string GetLogicalTree(int depth, object obj)
        {
            logical.Append($"{new string(' ', depth)}{obj.GetType().Name}\n");
            if (!(obj is DependencyObject))
            {
                return logical.ToString();
            }

            //LogicalTreeHelper.GetChildren 获取逻辑树子对象   
            //obj as DependencyObject  将obj转换成 依赖对象  
            foreach (object child in LogicalTreeHelper.GetChildren(obj as DependencyObject))
            {
                GetLogicalTree(depth + 5, child);
            }

            return logical.ToString();
        }

        private void ButtonLogical_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(GetLogicalTree(0, this), "逻辑树", MessageBoxButton.OK, MessageBoxImage.Question);
        }

    }
}
