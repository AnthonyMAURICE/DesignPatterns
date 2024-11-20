using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompoVisit
{
    public class Triangle : Shape
    {
        private int width;
        private int height;
        
        
        public Triangle(int _x, int _y, int width, int height) : base(_x, _y)
        {
            this.width = width;
            this.height = height;
            this.CalcPoints();
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        

        public override void Accept(IVisiteur<string> visiteur)
        {
            Console.WriteLine(visiteur.Visit(this));
        }

        public override RectangleF Accept(IVisiteur<RectangleF> visiteur)
        {
            return visiteur.Visit(this);
        }

        private void CalcPoints()
        {
            this.Points[0] = new Point(this.X + (this.width / 2), this.height);
            this.Points[1] = new Point(this.X + this.width, this.Y + this.height);
            this.Points[2] = new Point(this.X, this.Y + this.height);
        }
    }
}
