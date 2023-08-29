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
    /// CommandDemo.xaml 的交互逻辑
    /// </summary>
    public partial class CommandDemo : Window
    {
        //对于下面代码有几点需要注意的地方
        //使用命令可以避免自己写代码判断Button是否可用以及添加快捷键。
        //RoutedCommand是一个与业务逻辑无关的类，只负责在程序中“跑腿”而并不对命令目标做任何操作，TextBox并不是由它清空。那么对TextBox的清空操作是谁做的呢？
        //答案是CommandBinding。因为无论是探测命令是否执行还是命令送达目标，都会激发命令目标发送路由事件，这些路由事件会沿着UI元素树向上传递并最终被CommandBinding所
        //捕捉。本例中CommandBinding被安装在外围的StackPanel上，CommandBinding“站在高处”起一个侦听器的作用，而且专门针对clearCmd命令捕捉与其相关的路由事件。本例中，
        //当CommandBinding捕捉到CanExecute事件就会调用Cb_CanExecute方法（判断命令执行的条件是否满足，并反馈给命令供其影响命令源的状态）；当捕捉到的是Execute事件（表示
        //命令的Execute方法已经执行了，或说命令已经作用在了命令目标上，RoutedCommand的Execute方法不包含业务逻辑，只负责让命令目标激发Execute），则调用Cb_Executed方法。
        //第三，因为CanExecute事件的激发频率比较高，为了避免性能，在处理完后建议把e.Handled设为true。
        //第四，CommandBinding一定要设置在命令目标的外围控件上，不然无法捕捉到CanExecutehe和Execute路由事件。

        public CommandDemo()
        {
            InitializeComponent();
            InitializeCommand();
        }
        //声明并定义命令
        private RoutedCommand clearCmd = new RoutedCommand("Clear", typeof(CommandDemo));
        public void InitializeCommand()
        {
            //把命令赋值给命令源（发送者）并指定快捷键
            button1.Command = clearCmd;
            clearCmd.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Alt));
            //指定命令目标
            button1.CommandTarget = textBoxA;
            //创建命令关联
            CommandBinding cb = new CommandBinding();
            cb.Command = clearCmd;
            cb.CanExecute += Cb_CanExecute;
            cb.Executed += Cb_Executed;
            //把命令关联安置在外围控件上
            stackPanel.CommandBindings.Add(cb);
        }

        //当命令被送达目标后，此方法被调用
        private void Cb_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            textBoxA.Clear();
            //避免继续上传而降低程序性能
            e.Handled = true;
        }

        //当探测命令是否可以执行时，此方法被调用
        private void Cb_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxA.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            //避免继续上传而降低程序性能
            e.Handled = true;
        }
    }
}
