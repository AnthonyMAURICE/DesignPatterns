using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Binary : Expression
    {
        protected Expression expression1;
        protected Expression expression2;
        public Binary(Expression exp1, Expression exp2) 
        {
            this.expression1 = exp1;
            this.expression2 = exp2;
        }

        public abstract string FormatLeft();
        public abstract string FormatRight();

        public override string Format()
        {
            return this.FormatLeft() + this.FormatRight() + " = " + this.EvaluateItself().ToString();
        }
    }
}
