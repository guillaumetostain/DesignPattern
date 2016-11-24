using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.AbstractFactoryPattern
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            return null;
        }

        public override IShape GetShape(string shape)
        {
            switch (shape)
            {
                case "circle":
                    return new Circle();
                case "square":
                    return new Square();
                case "rectangle":
                    return new Rectangle();
                case null:
                    return null;
                default:
                    return null;
            }
        }
    }
}
