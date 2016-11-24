using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.DecoratorPattern
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IDecoratorShape shape) : base(shape)
        {
        }

        public new void Draw()
        {
            shape.Draw();
            SetRedBorder(shape);

        }

        private void SetRedBorder(IDecoratorShape shape)
        {
            Console.WriteLine("Red border color");
        }
    }
}
