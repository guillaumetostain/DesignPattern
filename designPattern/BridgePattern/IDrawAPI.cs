using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.BridgePattern
{
    public interface IDrawAPI
    {
        void DrawCircle(int x, int y, int radius);
    }
}
