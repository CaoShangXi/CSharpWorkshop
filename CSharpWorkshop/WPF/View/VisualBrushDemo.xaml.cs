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
    /// VisualBrushDemo.xaml 的交互逻辑
    /// </summary>
    public partial class VisualBrushDemo : Window
    {
        public VisualBrushDemo()
        {
            InitializeComponent();
        }

        double o = 1.0;
        private void CloneVisual(object sender, RoutedEventArgs e)
        {
            //VisualBrush:WPF中的每个控件都是由FrameworkElement类派生来的，而FrameworkElement又是由Visual类派生来的。
            //Visual意为“可视”之意，每个控件的可视化形象就可以通过Visual类的方法获得。获得这个可视化的形象后，
            //我们可以用这个形象进行填充，这就是VisualBrush。
            VisualBrush vBrush = new VisualBrush(this.realButton);
            Rectangle rect = new Rectangle();
            rect.Width = realButton.ActualWidth;
            rect.Height = realButton.ActualHeight;
            rect.Fill = vBrush;
            rect.Opacity = o;
            o -= 0.2;
            this.stackPanelRight.Children.Add(rect);
        }
    }
}
