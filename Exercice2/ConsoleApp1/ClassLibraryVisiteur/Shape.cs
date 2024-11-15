
namespace ClassLibraryCompoVisit
{
    public abstract class Shape
    {
        private int x;
        private int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Shape(int _x, int _y) 
        {
            this.x = _x;
            this.y = _y;
        }

        public abstract void Accept(IVisiteur visiteur);
    }
}
