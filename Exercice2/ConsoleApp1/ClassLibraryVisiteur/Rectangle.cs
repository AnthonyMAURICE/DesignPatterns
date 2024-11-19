using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompoVisit
{
    public class Rectangle : Shape
    {
        private Point pointA = new();
        private Point pointB = new();
        private Point pointC = new();
        private Point pointD = new();
        List<Point> points = [];

        public Rectangle(int _x, int _y, Point _pointA, Point _pointC) : base(_x, _y)
        {
            this.pointA = _pointA;
            this.pointC = _pointC;
            this.pointB.X = this.pointC.X;
            this.pointB.Y = this.pointA.Y;
            this.pointD.X = this.pointA.X;
            this.pointD.Y = this.pointC.Y;
            points.Add(this.pointA);
            points.Add(this.pointB);
            points.Add(this.pointC);
            points.Add(this.pointD);            
        }

        public override void Accept(IVisiteur visiteur)
        {
            visiteur.Visit(this);
        }
    }
}
