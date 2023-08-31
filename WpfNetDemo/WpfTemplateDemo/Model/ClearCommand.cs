using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfTemplateDemo.Model
{
    /// <summary>
    /// 自定义命令
    /// </summary>
    public class ClearCommand : ICommand
    {
        //当命令可执行状态发生改变时，应当被激发
        public event EventHandler CanExecuteChanged;

        //用于判断命令是否可以执行（暂不实现）
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        //命令执行，带有与业务相关的Clear逻辑
        public void Execute(object parameter)
        {
            IView view = parameter as IView;
            if (view != null)
            {
                view.Clear();
            }
        }
    }
}
