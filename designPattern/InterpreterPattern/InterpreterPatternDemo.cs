using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace designPattern.InterpreterPattern
{
    public static class InterpreterPatternDemo
    {
        public static IExpression GetMaleExpression()
        {
            IExpression robert = new TerminalExpression("robert");
            IExpression john = new TerminalExpression("john");
            return new OrExpression(robert, john);
        }

        public static IExpression GetMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("julie");
            IExpression married = new TerminalExpression("married");
            return new AndExpression(julie, married);
        }
    }
}
