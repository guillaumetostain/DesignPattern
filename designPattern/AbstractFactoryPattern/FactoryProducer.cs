using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            switch (choice)
            {
                case "shape":
                    return new ShapeFactory();
                case "color":
                    return new ColorFactory();
                case null:
                    return null;
                default:
                    return null;
            }
        }
    }
}
