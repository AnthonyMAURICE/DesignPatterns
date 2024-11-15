using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Substraction : Binary
    {
        public Substraction(Expression exp1, Expression exp2) : base(exp1, exp2)
        {
        }

        public override int EvaluateItself()
        {
            return this.expression1.EvaluateItself() - this.expression2.EvaluateItself();
        }

        public override string FormatLeft()
        {
            return this.expression1.FormatLeft() + " - " + this.expression2.FormatLeft();
        }

    }
}
