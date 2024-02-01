using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF.Model
{
    public class School:DependencyObject
    {


        public static int GetGrade(DependencyObject obj)
        {
            return (int)obj.GetValue(GradeProperty);
        }

        public static void SetGrade(DependencyObject obj, int value)
        {
            obj.SetValue(GradeProperty, value);
        }

        /// <summary>
        /// 可以很明显地看出，GradeProperty就是一个DependencyProperty类型成员变量，声明时一样
        //  使用public static readonly三个关键字共同修饰。唯一的不同就是注册附加属性使用的是名为
        //  RegisterAttached的方法，但参数却与使用Register方法无异。附加属性的包装器也与依赖属性不
        //  同一依赖属性使用CLR属性对GetValue和Set Value两个方法进行包装，附加属性则使用两个方
        //  法分别进行包装
        //  这样做完全是为了在使用的时候保持语句行文上的通畅。
        /// </summary>
        public static readonly DependencyProperty GradeProperty =
            DependencyProperty.RegisterAttached("Grade", typeof(int), typeof(School), new UIPropertyMetadata(0));


    }
}
