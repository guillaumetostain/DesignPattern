using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.DecoratorPattern
{
    public class ShapeDecorator : IDecoratorShape
    {
        public IDecoratorShape shape;

        public ShapeDecorator(IDecoratorShape shape)
        {
            this.shape = shape;
        }

        public void Draw()
        {
            shape.Draw();
        }
    }
}
