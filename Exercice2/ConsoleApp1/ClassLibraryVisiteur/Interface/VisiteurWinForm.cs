
using System.Drawing;

namespace ClassLibraryCompoVisit
{
    public class VisiteurWinForm : IVisiteur<RectangleF>
    {
        public RectangleF Visit(Circle circle)
        {
            return new RectangleF(circle.X, circle.Y, circle.Width, circle.Height);
        }

        public RectangleF Visit(Rectangle rectangle)
        {
            return new RectangleF(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        public RectangleF Visit(Triangle triangle)
        {
            return new RectangleF(triangle.X, triangle.Y, triangle.Width, triangle.Height);
        }

        public RectangleF Visit(Shapes shapes)
        {
            return new RectangleF(0, 0, 250, 250);
        }
    }
}
