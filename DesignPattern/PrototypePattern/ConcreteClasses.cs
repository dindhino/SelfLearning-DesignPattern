public class Rectangle : Shape
{
    public Rectangle()
    {
        type = "Rectangle";
    }

    public override void draw()
    {
        Console.WriteLine("Inside Rectangle::draw() method.");
    }
}

public class Square : Shape
{
    public Square()
    {
        type = "Square";
    }

    public override void draw()
    {
        Console.WriteLine("Inside Square::draw() method.");
    }
}

public class Circle : Shape
{
    public Circle()
    {
        type = "Circle ";
    }

    public override void draw()
    {
        Console.WriteLine("Inside Circle::draw() method.");
    }
}