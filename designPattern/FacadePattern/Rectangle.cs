using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.FacadePattern
{
    public class Rectangle : IFacadeShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw rectangle");
        }
    }
}
