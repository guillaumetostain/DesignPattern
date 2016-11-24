﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.AbstractFactoryPattern
{
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Fill green");
        }
    }
}
