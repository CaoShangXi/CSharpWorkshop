using System;
using System.Collections.Generic;
using System.Data;
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
    /// BindingValidation.xaml 的交互逻辑
    /// </summary>
    public partial class BindingValidation : Window
    {
        public BindingValidation()
        {
            InitializeComponent();
            Binding binding = new Binding("Value")
            {
                Source = this.slider1
            };
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            RangeValidationRule rvr = new RangeValidationRule();
            //Binding进行校验时的默认行为是认为来自Source的数据总是正确的，只有来自Target的数据
            //(因为Target多为UI控件，所以等价于用户输入的数据)才有可能有问题，为了不让有问题的数
            //据污染Source所以需要校验。换句话说，Binding只在Target被外部方法更新时校验数据，而来自
            //Binding的Source数据更新Target时是不会进行校验的。如果想改变这种行为，或者说当来自Source
            //的数据也有可能出间题时，我们就需要将校验条件的ValidatesOnTargetUpdated属性设为rue。
            rvr.ValidatesOnTargetUpdated = true;
            //显示验证过程的错误消息，首先，在创建Binding时要把Binding对象的NotifyOn ValidationError属性设为true,这样，当
            //数据校验失败的时候Binding会像报警器一样发出一个信号，这个信号会以Binding对象的Target
            //为起点在UI元素树上传播。信号每到达一个结点，如果这个结点上设置有对这种信号的侦听器（事
            //件处理器)，那么这个侦听器就会被触发用以处理这个信号。信号处理完后，程序员还可以选择是
            //让信号继续向下传播还是就此终止一这就是路由事件，信号在UI元素树上的传递过程就称为路
            //由(Route)。
            binding.NotifyOnValidationError = true;
            binding.ValidationRules.Add(rvr);
            this.textBox1.SetBinding(TextBox.TextProperty, binding);
            this.textBox1.AddHandler(Validation.ErrorEvent, new RoutedEventHandler(ValidationError));
        }

        public void ValidationError(object sender, RoutedEventArgs args)
        {
            if (Validation.GetErrors(this.textBox1).Count > 0)
            {
                this.textBox1.ToolTip = Validation.GetErrors(this.textBox1)[0].ErrorContent.ToString();
            }
        }
    }
}
