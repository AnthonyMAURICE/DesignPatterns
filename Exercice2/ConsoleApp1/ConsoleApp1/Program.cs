using ClassLibraryCompoVisit;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VisiteurConsole visiteurConsole = new();
            Circle circle = new(2, 5, 15, 15);
            Rectangle rectangle = new(5, 8, 25, 15);
            Triangle triangle = new(17, 34, 15, 15);
            //circle.Accept(visiteurConsole);
            //rectangle.Accept(visiteurConsole);
            //triangle.Accept(visiteurConsole);
            Shapes shapes = new(12, 15, 150, 150);
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(triangle);
            shapes.Accept(visiteurConsole);
        }
    }
}
