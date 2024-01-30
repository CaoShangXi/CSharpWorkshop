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
using System.Xml;

namespace WpfTemplateDemo.View
{
    /// <summary>
    /// BandingXml.xaml 的交互逻辑
    /// </summary>
    public partial class BindingXml : Window
    {
        public BindingXml()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //XmlDocument doc=new XmlDocument();
            //doc.Load(@".\RawData.xml");
            XmlDataProvider xdp = new XmlDataProvider();
            //使用Source属性直接指定XML文档所在位置（无论XML文档存储在本地硬盘还是在网络上）
            xdp.Source = new Uri(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"RawData.xml"));
            //xdp.Document=doc;
            //使用XPath选择需要暴露的数据
            //现在是需要暴露一组Student
            xdp.XPath = @"/StudentList/Student";
            this.listViewStudents.DataContext = xdp;
            this.listViewStudents.SetBinding(ListView.ItemsSourceProperty,new Binding());
            XmlDataProvider xdp2 = new XmlDataProvider();
            xdp2.Source = new Uri(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Books.xml"));
            xdp2.XPath = @"/Folder";
            this.view.SetBinding(ListView.ItemsSourceProperty,new Binding() { Source=xdp2});
        }
    }
}
