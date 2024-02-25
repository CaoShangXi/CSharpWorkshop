using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF.View
{
    public class MyButton : Button
    {
        public Type UserWindowType { get; set; }
        protected override void OnClick()
        {
            base.OnClick();// 激发Click事件
            Window win = Activator.CreateInstance(this.UserWindowType) as Window;
            if (win != null)
            {
                win.ShowDialog();
            }
        }
    }
}
