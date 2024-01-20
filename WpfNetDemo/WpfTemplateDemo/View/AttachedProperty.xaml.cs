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
using WpfTemplateDemo.Model;

namespace WpfTemplateDemo.View
{
    /// <summary>
    /// 附加属性演示
    /// </summary>
    public partial class AttachedProperty : Window
    {
        public AttachedProperty()
        {
            InitializeComponent();
            //使用C#代码的形式设置控件rect的附加属性Canvas.Left和Canvas.Top，并且绑定sliderX和sliderY的Value属性
            //this.rect.SetBinding(Canvas.LeftProperty, new Binding("Value") { Source = sliderX });
            //this.rect.SetBinding(Canvas.TopProperty, new Binding("Value") { Source = sliderY });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Human human = new Human();
            //为human对象添加附加属性Grade
            School.SetGrade(human, 6);
            //获取human的附加属性Grade的值
            int grade = School.GetGrade(human);
            MessageBox.Show(grade.ToString());
            //InitializeLayout();
        }

        /// <summary>
        /// 使用C#代码的形式设置控件Button的附加属性Grid.Column和Grid.Row
        /// </summary>
        public void InitializeLayout()
        {
            Grid grid = new Grid { ShowGridLines = true };
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            Button button =new Button{ Content = "OK" };
            Grid.SetColumn(button, 1);
            Grid.SetRow(button, 1);
            grid.Children.Add(button); 
            this.Content = grid;
        }
    }
}
