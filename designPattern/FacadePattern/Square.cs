﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.FacadePattern
{
    public class Square : IFacadeShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw square");
        }
    }
}
