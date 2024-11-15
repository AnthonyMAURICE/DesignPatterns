namespace ClassLibrary
{
    public abstract class Expression
    {
        public Expression()
        {

        }

        public abstract int EvaluateItself();
        public abstract string FormatLeft();

        public string Format()
        {
            return this.FormatLeft() + " = " + this.EvaluateItself();
        }
    }
}
