using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.AbstractFactoryPattern
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            switch (color)
            {
                case "red":
                    return new Red();
                case "green":
                    return new Green();
                case "blue":
                    return new Blue();
                case null:
                    return null;
                default:
                    return null;
            }
        }

        public override IShape GetShape(string shape)
        {
            return null;
        }
    }
}
