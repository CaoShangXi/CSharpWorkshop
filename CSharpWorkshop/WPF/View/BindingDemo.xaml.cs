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
using WPF.Model;
using WPF.View;

namespace WPF.View
{
    /// <summary>
    /// 绑定演示
    /// </summary>
    public partial class BindingDemo : Window
    {
        private Student stu;
        public BindingDemo()
        {
            InitializeComponent();
            //准备数据源
            //stu = new Student();
            //准备Binding
            //Binding binding = new Binding();
            //binding.Source = stu;
            //Binding指定访问路径
            //binding.Path = new PropertyPath("Name");
            //使用Binding连接数据源与Binding目标
            //第一个参数用于指定Binding的目标，本例中是this.textBoxName。
            //与数据源的Path原理类似，第二个参数用于为Binding指明把数据送达目标的哪个属性。
            //只是你会发现在这里用的不是对象的属性而是类的一个静态只读(staticeadony)的
            //DependeneyProperty类型成员变量！这就是我们后面要详细讲述的与Binding息息相关的
            //依赖属性。其实很好理解，这类属性的值可以通过Binding依赖在其他对象的属性值上，
            //被其他对象的属性值所驱动。
            //第三个参数很明了，就是指定使用哪个Binding实例将数据源与目标关联起来。
            //BindingOperations.SetBinding(this.textBoxName, TextBox.TextProperty, binding);
            //下面语法的作用是相同的
            textBoxName.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu = new Student() });

            //把Slider控件对象当作源、把它的Value属性作为路径。
            //Binding binding=new Binding() { Path=new PropertyPath("Value"),Source=this.slider1};
            //textBox1.SetBinding(TextBox.TextProperty, binding);
            //Binding binding=new Binding("Value") { Source=this.slider1};
            //textBox1.SetBinding(TextBox.TextProperty, binding);

            //多级路径绑定，如Text.Length，可以一直.下去
            //txt2.SetBinding(TextBox.TextProperty,new Binding("Text.Length") {Source=txt1 ,Mode=BindingMode.OneWay});

            //使用集合的索引器指定Path，可以使用集合名.[下标]或集合名[下标]绑定源
            txt4.SetBinding(TextBox.TextProperty, new Binding("Pens.[1]") { Source = stu = new Student() });

            //使用Path绑定集合中的元素
            List<string> stringList = new List<string> { "Tim", "Tom", "Blog" };
            //绑定集合中第一个元素
            txt5.SetBinding(TextBox.TextProperty, new Binding("/") { Source = stringList, Mode = BindingMode.OneWay });
            //绑定集合中第一个元素的Length属性
            txt6.SetBinding(TextBox.TextProperty, new Binding("/Length") { Source = stringList, Mode = BindingMode.OneWay });
            //绑定集合中第三个元素
            txt7.SetBinding(TextBox.TextProperty, new Binding("/[2]") { Source = stringList, Mode = BindingMode.OneWay });

            //使用Path绑定集合中的元素
            List<Country> countryList = new List<Country> {
            new Country
            {
                Name="中国",
                ProvinceList=new List<Province> {
                new Province
                {
                    Name="四川",
                    CityList=new List<City>
                    {
                        new City
                        {
                            Name="成都"
                        }
                    }
                }

                }
            }
            };
            //用Path绑定集合中第一个元素的Name属性
            txt8.SetBinding(TextBox.TextProperty, new Binding("/Name") { Source = countryList, Mode = BindingMode.OneWay });
            //用Path绑定集合中第一个元素的集合ProvinceList的Name属性
            txt9.SetBinding(TextBox.TextProperty, new Binding("/ProvinceList[0].Name") { Source = countryList, Mode = BindingMode.OneWay });
            //用Path绑定集合中第一个元素的子孙集合CityList的Name属性
            txt10.SetBinding(TextBox.TextProperty, new Binding("/ProvinceList/CityList[0].Name") { Source = countryList, Mode = BindingMode.OneWay });

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //对数据源进行更新，UI层也自动更新
            stu.Name += "Name";
        }
    }

    class City
    {

        public string Name { get; set; }
    }
    class Province
    {

        public string Name { get; set; }
        public List<City> CityList { get; set; }
    }
    class Country
    {

        public string Name { get; set; }
        public List<Province> ProvinceList { get; set; }
    }
}
