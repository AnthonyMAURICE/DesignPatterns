
using System.Drawing;

namespace ClassLibraryCompoVisit
{
    public abstract class Shape
    {
        private int x;
        private int y;
        private Point[] points = new Point[3];

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Point[] Points { get => points; set => points = value; }

        public Shape(int _x, int _y) 
        {
            this.x = _x;
            this.y = _y;
        }

        public abstract void Accept(IVisiteur<string> visiteur);
        public abstract RectangleF Accept(IVisiteur<RectangleF> visiteur);
    }
}
