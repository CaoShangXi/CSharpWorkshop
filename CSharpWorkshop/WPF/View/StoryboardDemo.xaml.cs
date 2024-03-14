﻿using System;
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
    /// StoryboardDemo.xaml 的交互逻辑
    /// </summary>
    public partial class StoryboardDemo : Window
    {
        public StoryboardDemo()
        {
            InitializeComponent();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    #region 使用C#代码完成场景
        //    Duration duration = new Duration(TimeSpan.FromMilliseconds(600));
        //    //红色小球匀速移动
        //    DoubleAnimation daRx = new DoubleAnimation();
        //    daRx.Duration = duration;
        //    daRx.To = 400;
        //    //绿色小球变速运动
        //    DoubleAnimationUsingKeyFrames dakGx = new DoubleAnimationUsingKeyFrames();
        //    dakGx.Duration = duration;
        //    SplineDoubleKeyFrame kfG = new SplineDoubleKeyFrame(400, KeyTime.FromPercent(1.0));
        //    kfG.KeySpline = new KeySpline(1, 0, 0, 1);
        //    dakGx.KeyFrames.Add(kfG);
        //    //蓝色小球变速运动
        //    DoubleAnimationUsingKeyFrames dakBx = new DoubleAnimationUsingKeyFrames();
        //    dakBx.Duration = duration;
        //    SplineDoubleKeyFrame kfB = new SplineDoubleKeyFrame(400, KeyTime.FromPercent(1.0));
        //    kfB.KeySpline = new KeySpline(0, 1, 1, 0);
        //    dakBx.KeyFrames.Add(kfB);
        //    //创建场景
        //    Storyboard storyboard = new Storyboard();
        //    Storyboard.SetTargetName(daRx, "ttR");
        //    Storyboard.SetTargetProperty(daRx, new PropertyPath(TranslateTransform.XProperty));
        //    Storyboard.SetTargetName(dakGx, "ttG");
        //    Storyboard.SetTargetProperty(dakGx, new PropertyPath(TranslateTransform.XProperty));
        //    Storyboard.SetTargetName(dakBx, "ttB");
        //    Storyboard.SetTargetProperty(dakBx, new PropertyPath(TranslateTransform.XProperty));
        //    storyboard.Duration = duration;
        //    storyboard.Children.Add(daRx);
        //    storyboard.Children.Add(dakGx);
        //    storyboard.Children.Add(dakBx);
        //    storyboard.Begin(this);
        //    storyboard.Completed += (a, b) => { MessageBox.Show(ttR.X.ToString()); };
        //    #endregion
        //}
    }
}
