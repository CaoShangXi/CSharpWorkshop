using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTemplateDemo.Model
{
    /// <summary>
    /// 计算器
    /// </summary>
    public class Calculator
    {
        //加法
        public string Add(string argl, string arg2)
        {
            double x = 0;
            double y = 0;
            double z = 0;
            if (double.TryParse(argl, out x) && double.TryParse(arg2, out y))
            {
                z = x + y;
                return z.ToString();
            }
            return "Input Error!";
        }
    }
}
