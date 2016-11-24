using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.InterpreterPattern
{
    public interface IExpression
    {
        bool Interpret(string context);
    }
}
