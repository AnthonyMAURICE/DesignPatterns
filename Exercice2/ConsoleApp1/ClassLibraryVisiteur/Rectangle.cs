using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCompoVisit
{
    public class Rectangle : Shape
    {
        public Rectangle(int _x, int _y) : base(_x, _y)
        {
        }

        public override void Accept(IVisiteur visiteur)
        {
            visiteur.Visit(this);
        }
    }
}
