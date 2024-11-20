using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompoVisit
{
    public class Circle : Shape
    {
        private int width;
        private int height;
        public Circle(int _x, int _y, int width, int height) : base(_x, _y)
        {
            this.width = width;
            this.height = height;
        }

        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }

        public override void Accept(IVisiteur<string> visiteur)
        {
            Console.WriteLine(visiteur.Visit(this));
        }

        public override RectangleF Accept(IVisiteur<RectangleF> visiteur)
        {
            return visiteur.Visit(this);
        }
    }
}
