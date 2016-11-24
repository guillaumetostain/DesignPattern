using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.BridgePattern
{
    public class GreenCircle : IDrawAPI
    {
        public void DrawCircle(int x, int y, int radius)
        {
            Console.WriteLine("Draw green circle => x : " + x + ", y : " + y + ", radius : " + radius);
        }
    }
}
