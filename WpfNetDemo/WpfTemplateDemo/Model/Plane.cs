﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTemplateDemo.Common;

namespace WpfTemplateDemo.Model
{
    /// <summary>
    /// 飞机
    /// </summary>
    public class Plane
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
    }
}
