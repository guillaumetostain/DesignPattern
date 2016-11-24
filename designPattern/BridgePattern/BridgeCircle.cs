using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.BridgePattern
{
    public class BridgeCircle : BridgeShape
    {
        private int x, y, radius;

        public BridgeCircle(int x, int y, int radius, IDrawAPI drawAPI) : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            drawAPI.DrawCircle(x, y, radius);
        }
    }
}
