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

namespace WPF
{
    /// <summary>
    /// XMLToHierarchicalDataTemplate_MenuItem.xaml 的交互逻辑
    /// </summary>
    public partial class XMLToHierarchicalDataTemplate_MenuItem : Window
    {
        public XMLToHierarchicalDataTemplate_MenuItem()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item=e.OriginalSource as MenuItem;
            XmlElement element= item.Header as XmlElement;
            MessageBox.Show(element.Attributes["Name"].Value);
        }
    }
}
