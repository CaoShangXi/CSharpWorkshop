using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF.Common;

namespace WPF.Model
{
    [TypeConverter(typeof(StringToHumanTypeConverter))]
    public class Human:DependencyObject
    {
        public string Name { get; set; }
        public Human Child { get; set; }
    }
}
