using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompoVisit
{
    
    public class Shapes : Shape
    {
        private int width;
        private int height;
        private List<Shape> shapesList;

        public List<Shape> ShapesList { get => shapesList; set => shapesList = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public Shapes(int _x, int _y, int width, int height) : base(_x, _y)
        {
            this.width = width;
            this.height = height;
            shapesList = [];
        }

        public void Add(Shape shape) 
        {
            this.shapesList.Add(shape);
        }

        public override void Accept(IVisiteur<string> visiteur)
        {
            Console.WriteLine(visiteur.Visit(this));
            if (shapesList.Count > 0) 
            {
                this.ShapesLoop(visiteur);
            }
        }

        private void ShapesLoop(IVisiteur<string> visiteur)
        {
            foreach (Shape shape in this.shapesList)
            {
                shape.Accept(visiteur);
            }
        }

        public override RectangleF Accept(IVisiteur<RectangleF> visiteur)
        {
            return visiteur.Visit(this);
        }

    }
}
