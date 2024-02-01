using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF.Model
{
    public class RangeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double d = 0;
            if (double.TryParse(value.ToString(), out d))
            {
                if (d >= 0 && d <= 100)
                {
                    return new ValidationResult(true, null);
                }
            }
            //Binding的ValidationRules属性类型是Collection<ValidationRule>,从它的名称和数据类型可以得知可以为每个Binding设置多个数据校验条件，
            //每个条件是一个ValidationRule类型对象。ValidationRule类是个抽象类，在使用的时候我们需要创建它的派生类并实现它的Validate方法。
            //Validate方法的返回值是ValidationResult类型对象，如果校验通过，就把ValidationResult对象的IsValid属性设为true,
            //反之，需要把IsValid属性设为false并为其ErrorContent属性设置一个合适的消息内容（一般是个字符串）。
            return new ValidationResult(false, "Validation Failed");
        }
    }
}
