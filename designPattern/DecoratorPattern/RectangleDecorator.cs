using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.DecoratorPattern
{
    public class RectangleDecorator : IDecoratorShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw rectangle");
        }
    }
}
