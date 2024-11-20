
using System.Drawing;

namespace ClassLibraryCompoVisit
{
    public abstract class Shape
    {
        private int x;
        private int y;
        private Point[] points = new Point[3];
        private string name;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Point[] Points { get => points; set => points = value; }
        public string Name { get => name; set => name = value; }

        public Shape(int _x, int _y) 
        {
            this.x = _x;
            this.y = _y;
            this.name = this.GetType().Name;
        }

        public abstract void Accept(IVisiteur<string> visiteur);
        public abstract RectangleF Accept(IVisiteur<RectangleF> visiteur);
    }
}
