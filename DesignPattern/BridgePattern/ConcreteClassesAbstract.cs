public class Circle : Shape
{
    private int x, y, radius;
    public Circle(int x, int y, int radius, DrawAPI drawAPI) : base(drawAPI)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public override void Draw()
    {
        drawAPI.DrawCircle(radius, x, y);
    }
}