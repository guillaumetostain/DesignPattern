using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.BuilderPattern
{
    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "ChickenBurger";
        }

        public override float Price()
        {
            return 6;
        }
    }
}
