namespace ClassLibraryCompoVisit
{
    public interface IVisiteur
    {
        public void Visit(Circle circle);
        public void Visit(Rectangle rectangle);
        public void Visit(Triangle triangle);
        public void Visit(Shapes shapes);
    }
}
