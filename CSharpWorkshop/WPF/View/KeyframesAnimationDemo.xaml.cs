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
    /// KeyframesAnimationDemo.xaml 的交互逻辑
    /// </summary>
    public partial class KeyframesAnimationDemo : Window
    {
        public KeyframesAnimationDemo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ////使用关键帧动画情况就会大有改观一我们只需要创建两个DoubleAnimationUsingKeyFrames
            ////实例，一个控制TranslateTransform的X属性、另一个控制TranslateTransform的Y属性即可。每
            ////个DoubleAnimationUsingKeyFrames各拥有三个关键帧用于指明X或Y在三个时间点（两个拐点
            ////和终点)应该达到什么样的值。
            //DoubleAnimationUsingKeyFrames dakX = new DoubleAnimationUsingKeyFrames();
            //DoubleAnimationUsingKeyFrames dakY = new DoubleAnimationUsingKeyFrames();
            ////设置动画总时长
            //dakX.Duration = new Duration(TimeSpan.FromMilliseconds(900));
            //dakY.Duration = new Duration(TimeSpan.FromMilliseconds(900));
            ////创建、添加关键帧
            //LinearDoubleKeyFrame x_kf_1 = new LinearDoubleKeyFrame();
            //LinearDoubleKeyFrame x_kf_2 = new LinearDoubleKeyFrame();
            //LinearDoubleKeyFrame x_kf_3 = new LinearDoubleKeyFrame();
            //x_kf_1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(300));
            //x_kf_1.Value = 200;
            //x_kf_2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(600));
            //x_kf_2.Value = 0;
            //x_kf_3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(900));
            //x_kf_3.Value = 200;
            //dakX.KeyFrames.Add(x_kf_1);
            //dakX.KeyFrames.Add(x_kf_2);
            //dakX.KeyFrames.Add(x_kf_3);
            //LinearDoubleKeyFrame y_kf_1 = new LinearDoubleKeyFrame();
            //LinearDoubleKeyFrame y_kf_2 = new LinearDoubleKeyFrame();
            //LinearDoubleKeyFrame y_kf_3 = new LinearDoubleKeyFrame();
            ////一个绝对时间点。使用KeyTime.FromPercent静态方法则可以获得以百分比计算的相对时间点，程序将
            ////整个关键帧动画的时长(Duration)视为100 %。我们可以把下面的代码更改为这样：
            //y_kf_1.KeyTime = KeyTime.FromPercent(0.33);
            ////y_kf_1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(300));
            //y_kf_1.Value = 0;
            //y_kf_2.KeyTime = KeyTime.FromPercent(0.66);
            ////y_kf_2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(600));
            //y_kf_2.Value = 180;
            //y_kf_3.KeyTime = KeyTime.FromPercent(1.0);
            ////y_kf_3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(900));
            //y_kf_3.Value = 180;
            //dakY.KeyFrames.Add(y_kf_1);
            //dakY.KeyFrames.Add(y_kf_2);
            //dakY.KeyFrames.Add(y_kf_3);
            ////执行动画
            //this.tt.BeginAnimation(TranslateTransform.XProperty, dakX);
            //this.tt.BeginAnimation(TranslateTransform.YProperty, dakY);

            #region 特殊的关键帧
            //4个派生类中最常用的是SplineDoubleKeyFrame(SplineDoubleKeyFrame可以替代
            //LinearDoubleKeyFrame)。使用SplineDoubleKeyFrame可以非常方便地制作非匀速动画，因为它使
            //用一条贝塞尔曲线来控制目标属性值的变化速率。这条用于控制变化速率的贝塞尔曲线的起点是
            //(0, 0)和(1, 1)，分别映射着目标属性的变化起点和变化终点，意思是目标属性值由0 % 变化到100 %。
            //这条贝塞尔曲线有两个控制点ControlPointl和ControlPoint2,意思是贝塞尔曲线从起点出发先
            //向ControlPoint1的方向前进、再向ControlPoint2的方向前进、最后到达终点，形成一条平滑的曲
            //线。如果设置ControlPoint1和ControlPoint.2的横纵坐标值相等，比如(0, 0)、(0.5, 0.5)、(1, 1)，则贝
            //塞尔曲线成为一条直线，这时候SplineDoubleKeyFrame与LinearDoubleKeyFrame是等价的。
            //创建动画
            DoubleAnimationUsingKeyFrames dakX = new DoubleAnimationUsingKeyFrames();
            dakX.Duration = new Duration(TimeSpan.FromMilliseconds(1000));
            //创建、添加关键帧
            SplineDoubleKeyFrame kf = new SplineDoubleKeyFrame();
            kf.KeyTime = KeyTime.FromPercent(1);
            kf.Value = 400;
            KeySpline ks = new KeySpline();
            ks.ControlPoint1 = new Point(0, 1);
            ks.ControlPoint2 = new Point(1, 0);
            kf.KeySpline = ks;
            dakX.KeyFrames.Add(kf);
            //执行动画
            this.tt.BeginAnimation(TranslateTransform.XProperty, dakX);
            #endregion
        }
    }
}
