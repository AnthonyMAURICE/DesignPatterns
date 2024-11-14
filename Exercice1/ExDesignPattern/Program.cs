using ClassLibrary;

namespace ExDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Expression exp1 = new Addition(new Integer(3), new Integer(2));
            //int resultat1 = exp1.EvaluateItself();

            Expression exp2 = new Addition(new Substraction(new Integer(3), new Integer(6)), new Integer(7));
            //int resultat2 = exp2.EvaluateItself();

            Console.WriteLine(exp1.Format());
            Console.WriteLine(exp2.Format());

        }
    }
}
