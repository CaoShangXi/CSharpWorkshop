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
            //使用关键帧动画情况就会大有改观一我们只需要创建两个DoubleAnimationUsingKeyFrames
            //实例，一个控制TranslateTransform的X属性、另一个控制TranslateTransform的Y属性即可。每
            //个DoubleAnimationUsingKeyFrames各拥有三个关键帧用于指明X或Y在三个时间点（两个拐点
            //和终点)应该达到什么样的值。
            DoubleAnimationUsingKeyFrames dakX = new DoubleAnimationUsingKeyFrames();
            DoubleAnimationUsingKeyFrames dakY = new DoubleAnimationUsingKeyFrames();
            //设置动画总时长
            dakX.Duration = new Duration(TimeSpan.FromMilliseconds(900));
            dakY.Duration = new Duration(TimeSpan.FromMilliseconds(900));
            //创建、添加关键帧
            LinearDoubleKeyFrame x_kf_1 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame x_kf_2 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame x_kf_3 = new LinearDoubleKeyFrame();
            x_kf_1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(300));
            x_kf_1.Value = 200;
            x_kf_2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(600));
            x_kf_2.Value = 0;
            x_kf_3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(900));
            x_kf_3.Value = 200;
            dakX.KeyFrames.Add(x_kf_1);
            dakX.KeyFrames.Add(x_kf_2);
            dakX.KeyFrames.Add(x_kf_3);
            LinearDoubleKeyFrame y_kf_1 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame y_kf_2 = new LinearDoubleKeyFrame();
            LinearDoubleKeyFrame y_kf_3 = new LinearDoubleKeyFrame();
            //一个绝对时间点。使用KeyTime.FromPercent静态方法则可以获得以百分比计算的相对时间点，程序将
            //整个关键帧动画的时长(Duration)视为100 %。我们可以把下面的代码更改为这样：
            y_kf_1.KeyTime = KeyTime.FromPercent(0.33);
            //y_kf_1.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(300));
            y_kf_1.Value = 0;
            y_kf_2.KeyTime = KeyTime.FromPercent(0.66);
            //y_kf_2.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(600));
            y_kf_2.Value = 180;
            y_kf_3.KeyTime = KeyTime.FromPercent(1.0);
            //y_kf_3.KeyTime = KeyTime.FromTimeSpan(TimeSpan.FromMilliseconds(900));
            y_kf_3.Value = 180;
            dakY.KeyFrames.Add(y_kf_1);
            dakY.KeyFrames.Add(y_kf_2);
            dakY.KeyFrames.Add(y_kf_3);
            //执行动画
            this.tt.BeginAnimation(TranslateTransform.XProperty, dakX);
            this.tt.BeginAnimation(TranslateTransform.YProperty, dakY);
        }
    }
}
