using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompoVisit
{
    public class Circle : Shape
    {
        public Circle(int _x, int _y) : base(_x, _y)
        {
        }

        public override void Accept(IVisiteur visiteur)
        {
            visiteur.Visit(this);
        }
    }
}
