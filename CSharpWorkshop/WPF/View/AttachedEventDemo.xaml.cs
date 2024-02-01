using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// 附加事件演示
    /// </summary>
    public partial class AttachedEventDemo : Window
    {
        public AttachedEventDemo()
        {
            InitializeComponent();
            //为外层Grid添加路由事件侦听器
            //this.gridMain.AddHandler(Student.NameChangedEvent, new RoutedEventHandler(StudenNameChangedHandler));
            //或者使用下面的语法也可以
            Student.AddNameChangedHandler(this.gridMain, new RoutedEventHandler(StudenNameChangedHandler));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student { Id = 101, Name = "Tim" };
            //准备事件消息并发送路由事件
            RoutedEventArgs args = new RoutedEventArgs(Student.NameChangedEvent, stu);
            this.button1.RaiseEvent(args);
        }

        /// <summary>
        /// Grid捕捉到NameChangedEvent后的处理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void StudenNameChangedHandler(object sender, RoutedEventArgs args)
        {
            //因为Student不是UIElement的派生类，所以它不具有RaiseEvent这个方法，为了发送路
            //由事件就不得不“借用”一下Button的RaiseEvent方法了。在窗体的构造器中为Grid元素添加了
            //对Student..NameChangedEvent的侦听，这与添加对路由事件的侦听没有任何区别。Grid在捕捉到
            //路由事件后会显示事件消息源（一个Student实例）的Id。
            MessageBox.Show((args.OriginalSource as Student).Id.ToString());
        }
    }
}
