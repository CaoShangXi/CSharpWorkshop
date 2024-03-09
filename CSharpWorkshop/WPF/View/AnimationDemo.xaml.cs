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
    /// AnimationDemo.xaml 的交互逻辑
    /// </summary>
    public partial class AnimationDemo : Window
    {
        public AnimationDemo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //#region 注意
            ////这段代码有以下几处值得注意的地方：
            ////因为指定了daX和daY的起始值为0，所以每次按钮都会“跳”回窗体的左上角开始动画。如果想让按钮从当前
            ////位置开始下一次动画，只需要把“daX.From = 0D:"和“daY.From=0D:”两句代码移除即可.
            ////尽管表现出来的是Button在移动，但DoubleAnimation的作用目标并不是Button而是TranslateTransform实例，
            ////因为TranslateTransform实例是Button的RenderTransform属性值，所以Button“看上去”是移动了，
            ////前面说过，能用来制作动画的属性必须是依赖属性，TranslateTransform的XProperty和YProperty就是两个
            ////依赖属性。
            ////UIElement和Animatable两个类都定义有BeginAnimation这个方法。TranslateTransform派生自Animatable类，所以具有
            ////这个方法。这个方法的调用者就是动画要作用的目标对象，两个参数分别指明被作用的依赖属性(TranslateTransform
            ////XProperty和TranslateTransform.YProperty)和设计好的动画(daX和daY)。可以猜想，如果需要动画改变Button的宽
            ////度或高度（这两个属性也是Double类型），也应该先创建DoubleAnimation实例，然后设置起止值和动画时间，最后调
            ////用Button的BeginAnimation方法、使用动画对象影响Button.WidthProperty和Button..HeightProperty
            //DoubleAnimation daX = new DoubleAnimation();
            //DoubleAnimation daY = new DoubleAnimation();
            ////指定起点
            //daX.From = 0D;
            //daY.From = 0D;
            ////指定终点
            //Random r = new Random();
            //daX.To = r.NextDouble() * 300;
            //daY.To = r.NextDouble() * 300;
            ////指定时长
            //Duration duration = new Duration(TimeSpan.FromMilliseconds(300));
            //daX.Duration = duration;
            //daY.Duration = duration;
            ////动画的主体是TranslateTransform变形，而非Button
            //this.tt.BeginAnimation(TranslateTransform.XProperty, daX);
            //this.tt.BeginAnimation(TranslateTransform.YProperty, daY);
            //#endregion

            DoubleAnimation daX = new DoubleAnimation();
            DoubleAnimation daY = new DoubleAnimation();
            //指定幅度
            daX.By = 100D;
            daY.By = 100D;
            //指定时长
            Duration duration = new Duration(TimeSpan.FromMilliseconds(300));
            daX.Duration = duration;
            daY.Duration = duration;
            //动画的主体是TranslateTransform变形，而非Button
            this.tt.BeginAnimation(TranslateTransform.XProperty, daX);
            this.tt.BeginAnimation(TranslateTransform.YProperty, daY);
        }
    }
}
