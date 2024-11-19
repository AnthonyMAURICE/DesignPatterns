using ClassLibraryCompoVisit;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VisiteurConsole visiteurConsole = new();
            Circle circle = new(2, 5);
            Rectangle rectangle = new(5, 8, new System.Drawing.Point(15, 10), new System.Drawing.Point(20, 25));
            Triangle triangle = new(17, 34);
            //circle.Accept(visiteurConsole);
            //rectangle.Accept(visiteurConsole);
            //triangle.Accept(visiteurConsole);
            Shapes shapes = new(12, 15);
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(triangle);
            shapes.Accept(visiteurConsole);
        }
    }
}
