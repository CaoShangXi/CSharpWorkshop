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
using System.Xml.Linq;
using WpfTemplateDemo.Model;

namespace WpfTemplateDemo.View
{
    /// <summary>
    /// BindingLINQ.xaml 的交互逻辑
    /// </summary>
    public partial class BindingLINQ : Window
    {
        public BindingLINQ()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //List<Student> stuList = new List<Student>()
            //{
            //    new Student{Id=0,Name="Tim",Age=29 },
            //    new Student{Id=1,Name="Tom",Age=28 },
            //    new Student{Id=2,Name="Kyle",Age=27 },
            //    new Student{Id=3,Name="Tony",Age=26 },
            //    new Student{Id=4,Name="Vina",Age=25 },
            //    new Student{Id=5,Name="Mike",Age=24 },
            //};
            //this.listViewStudents.ItemsSource=from stu in stuList where stu.Name.StartsWith("T") select stu;

            //    DataTable dt = new DataTable();
            //    dt.Columns.Add("Id");
            //    dt.Columns.Add("Name");
            //    dt.Columns.Add("Age");
            //    dt.Rows.Add(0,"Tim",27);
            //    dt.Rows.Add(1,"Tom",26);
            //    dt.Rows.Add(2,"Kyle",25);
            //    dt.Rows.Add(3,"Tony",24);
            //    dt.Rows.Add(4,"Vina",23);
            //    dt.Rows.Add(5,"Mike",22);
            //    this.listViewStudents.ItemsSource =
            //    from row in dt.Rows.Cast<DataRow>()
            //    where Convert.ToString(row["Name"]).StartsWith("T")
            //    select new Student
            //    {
            //        Id = int.Parse(row["Id"].ToString()),
            //        Name = row["Name"].ToString(),
            //        Age = int.Parse(row["Age"].ToString())
            //    };

            string xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                            <StudentList>
                            <Class>
                            <Student Id=""0"" Name=""Tim"" Age=""29""/>
                            <Student Id=""1"" Name=""Tom"" Age=""28""/>
                            <Student Id=""2"" Name=""Mess"" Age=""27""/>
                            </Class>
                            <Class>
                            <Student Id=""3"" Name=""Tony"" Age=""26""/>
                            <Student Id=""4"" Name=""Vina"" Age=""25""/>
                            <Student Id=""5"" Name=""Emily"" Age=""24""/>
                            </Class>
                            </StudentList>";
            XDocument xdoc = XDocument.Parse(xml);
            this.listViewStudents.ItemsSource =
            from element in xdoc.Descendants("Student")
            where element.Attribute("Name").Value.StartsWith("T")
            select new Student
            {
                Id = int.Parse(element.Attribute("Id").Value),
                Name = element.Attribute("Name").Value,
                Age = int.Parse(element.Attribute("Age").Value)
            };
        }
    }
}
