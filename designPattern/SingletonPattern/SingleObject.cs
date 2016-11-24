using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern
{
    public class SingleObject
    {
        private static SingleObject instance;

        private SingleObject() { }

        public static SingleObject Instance()
        {
            if (instance == null)
            {
                instance = new SingleObject();
            }
            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("Hello World");
        }
    }
}
