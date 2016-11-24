using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.BuilderPattern
{
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "VegBurger";
        }

        public override float Price()
        {
            return 5;
        }
    }
}
