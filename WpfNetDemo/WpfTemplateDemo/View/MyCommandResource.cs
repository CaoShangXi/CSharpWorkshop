using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfTemplateDemo.Model;

namespace WpfTemplateDemo.View
{
    //自定义命令源
    public class MyCommandResource : UserControl, ICommandSource
    {
        //继承自ICommandSource的三个属性
        public ICommand Command { get; set; }

        public object CommandParameter { get; set; }

        public IInputElement CommandTarget { get; set; }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            //在命令目标上执行命令，或称让命令作用于命令目标
            if (CommandTarget!=null)
            {
                Command.Execute(CommandTarget);
            }
        }
    }
}
