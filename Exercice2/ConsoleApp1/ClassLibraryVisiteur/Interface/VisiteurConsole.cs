using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompoVisit
{
    public class VisiteurConsole : IVisiteur<string>
    {
        string IVisiteur<string>.Visit(Circle circle)
        {
            return "Je suis un cercle à la position " + circle.X + ";" + circle.Y;
        }

        string IVisiteur<string>.Visit(Rectangle rectangle)
        {
            return "Je suis un rectangle à la position " + rectangle.X + ";" + rectangle.Y;
        }

        string IVisiteur<string>.Visit(Triangle triangle)
        {
            return "Je suis un triangle à la position " + triangle.X + ";" + triangle.Y;
        }

        string IVisiteur<string>.Visit(Shapes shapes)
        {
            return shapes.ShapesList.Count > 0 ? "Je suis un ensemble de figures comprenant : " : "Je suis un ensemble de figures, mais vide";
        }
    }
}
