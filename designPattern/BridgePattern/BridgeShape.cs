using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.BridgePattern
{
    public abstract class BridgeShape
    {
        public IDrawAPI drawAPI;

        public BridgeShape(IDrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }

        public abstract void Draw();
    }
}
