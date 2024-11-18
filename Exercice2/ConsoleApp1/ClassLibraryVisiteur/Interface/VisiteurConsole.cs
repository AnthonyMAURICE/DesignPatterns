using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompoVisit
{
    public class VisiteurConsole : IVisiteur
    {
        public void Visit(Circle circle)
        {
            Console.WriteLine("Je suis un cercle à la position " + circle.X + ";" + circle.Y);
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine("Je suis un rectangle à la position " + rectangle.X + ";" + rectangle.Y);
        }

        public void Visit(Triangle triangle)
        {
            Console.WriteLine("Je suis un triangle à la position " + triangle.X + ";" + triangle.Y);
        }

        public void Visit(Shapes shapes)
        {
            Console.WriteLine(shapes.ShapesList.Count > 0? "Je suis un ensemble de figures comprenant : " : "Je suis un ensemble de figures, mais vide");
        }
    }
}
