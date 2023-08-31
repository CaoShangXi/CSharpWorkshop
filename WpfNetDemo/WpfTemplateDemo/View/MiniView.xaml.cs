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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfTemplateDemo.Model;

namespace WpfTemplateDemo.View
{
    /// <summary>
    /// MiniView.xaml 的交互逻辑
    /// </summary>
    public partial class MiniView : UserControl,IView
    {
        public MiniView()
        {
            InitializeComponent();
        }

        public bool IsChanged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //用于清除内容的业务逻辑
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void SetBinding()
        {
            throw new NotImplementedException();
        }
    }
}
