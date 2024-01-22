using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfTemplateDemo.Model
{
    public class TimeButton : Button
    {
        //EventManager.RegisterRoutedEvent方法的四个参数
        //1.第一个参数为string类型，被称为路由事件的名称，按微软的建议，这个字符串应该与Routedvent变量的前缀和CLR事件包装器的名称一致。
        //2.第二个参数称为路由事件的策略。WPF路由事件有3种路由策略：
        //Bubble,冒泡式：路由事件由事件的激发者出发向它的上级容器一层一层路由，直至最外层容器(Window或者Page)。因为是由树的底端向顶端移动，而且从事件激发元素到UI树的树根只有确定的一条路径，所以这种策略被形象地命名为“冒泡式”。
        //Tunnel，隧道式：事件的路由方向正好与Bubble策略相反，是由UI树的树根向事件激发控件移动。因为从UI树根向树底移动时有很多路径，但我们希望是由树根向激发事件的控件移动，这就好像在树根与目标控件之间挖掘了一条隧道，事件只能沿着隧道移动，所以称之为“隧道式”。
        //Direct,直达式：模仿CLR直接事件，直接将事件消息送达事件处理器。
        //3.第三个参数用于指定事件处理器的类型。事件处理器的返回值类型和参数列表必须与此参数指定的委托保持一致，不然会导致在编译时抛出异常。
        //4.第四个参数用于指明路由事件的宿主（拥有者）是哪个类型。与依赖属性类似，这个类型和第一个数共同参与一些底层算法且产生这个路由事件的HashCode并被注册到程序的路由事件列表中。
        /// <summary>
        /// 声明和注册路由事件,导出时间事件
        /// </summary>
        public static readonly RoutedEvent ReportTimeEvent = EventManager.RegisterRoutedEvent
        ("ReportTime", RoutingStrategy.Tunnel, typeof(EventHandler<ReportTimeEventArgs>), typeof(TimeButton));

        //CLR事件包装器
        public event RoutedEventHandler ReportTime
        {
            //当使用操作符+=添加对路由事件的侦听处理时，add分支的代码会被调用
            add { this.AddHandler(ReportTimeEvent, value); }
            //当使用操作符-=添加对路由事件的侦听处理时，remove分支的代码会被调用
            remove { this.RemoveHandler(ReportTimeEvent, value); }
        }

        //激发路由事件，借用Cick事件的激发方法
        protected override void OnClick()
        {
            base.OnClick();// 保证Button原有功能正常使用、Click事件能被激发
            ReportTimeEventArgs args = new ReportTimeEventArgs(ReportTimeEvent, this);
            args.ClickTime = DateTime.Now;
            this.RaiseEvent(args);
        }
    }
}