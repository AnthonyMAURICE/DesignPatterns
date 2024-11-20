namespace ClassLibraryCompoVisit
{
    public interface IVisiteur<T>
    {
        T Visit(Circle circle);
        T Visit(Rectangle rectangle);
        T Visit(Triangle triangle);
        T Visit(Shapes shapes);
    }
}
