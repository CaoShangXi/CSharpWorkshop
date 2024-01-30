using System;
using System.Collections.Generic;
using System.IO;
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
using WpfTemplateDemo.Model;

namespace WpfTemplateDemo.View
{
    /// <summary>
    /// BadingObjectDataProvider.xaml 的交互逻辑
    /// </summary>
    public partial class BadingObjectDataProvider : Window
    {
        public BadingObjectDataProvider()
        {
            InitializeComponent();
            this.SetBinding();
        }

        private void SetBinding()
        {
            //创建并配置ObjectDataProvider对象
            ObjectDataProvider odp = new ObjectDataProvider();
            odp.ObjectInstance = new Calculator();
            odp.MethodName = "Add";
            odp.MethodParameters.Add("0");
            odp.MethodParameters.Add("0");
            //以ObjectDataProvider对象为Source创建Binding
            Binding bindingToArgl = new Binding("MethodParameters[0]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            //属性所引用的集合中的第一个元素。BindsDirectlyToSource=tue这句的意思是告诉Binding对象只负
            //责把从UI元素收集到的数据写入其直接Source(即ObjectDataProvider对象)而不是被
            //ObjeDataProvider对象包装着的Calculator对象。同时，UpdateSourceTrigger属性被设置为
            //有更新立刻将值传▣Source。
            Binding bindingToArg2 = new Binding("MethodParameters[1]")
            {
                Source = odp,
                BindsDirectlyToSource = true,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            //第三个Binding对象仍然使用ObjectDataProvider对象作为Source,但使用“.”作为Path
            //前面说过，当数据源本身就代表数据的时候就使用“，”作Path,并且“，”在XAML代码里可以省略不写。
            Binding bindingToResult = new Binding(".") { Source = odp };
            //将Binding关联到UI元素上
            this.textBoxArgl.SetBinding(TextBox.TextProperty, bindingToArgl);
            this.textBoxArg2.SetBinding(TextBox.TextProperty, bindingToArg2);
            this.textBoxResult.SetBinding(TextBox.TextProperty, bindingToResult);
        }
    }
}
