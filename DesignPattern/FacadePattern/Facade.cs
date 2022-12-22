public class ShapeMaker
{
    private Shape circle, rectangle, square;
    public ShapeMaker()
    {
        circle = new Circle();
        rectangle = new Rectangle();
        square = new Square();
    }
    public void DrawCircle()
    {
        circle.Draw();
    }
    public void DrawRectangle()
    {
        rectangle.Draw();
    }
    public void DrawSquare()
    {
        square.Draw();
    }

}