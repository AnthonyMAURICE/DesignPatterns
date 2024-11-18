using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompoVisit
{
    
    public class Shapes : Shape
    {
        private List<Shape> shapesList;

        public List<Shape> ShapesList { get => shapesList; set => shapesList = value; }

        public Shapes(int _x, int _y) : base(_x, _y)
        {
            shapesList = [];
        }

        public void Add(Shape shape) 
        {
            this.shapesList.Add(shape);
        }

        public override void Accept(IVisiteur visiteur)
        {
            visiteur.Visit(this);
            if (shapesList.Count > 0) 
            {
                this.ShapesLoop(visiteur);
            }
        }

        private void ShapesLoop(IVisiteur visiteur)
        {
            foreach (Shape shape in this.shapesList)
            {
                shape.Accept(visiteur);
            }
        }
    }
}
