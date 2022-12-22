public class Rectangle : Shape
{
    void Shape.Draw()
    {
        Console.WriteLine("Rectangle::draw()");
    }
}

public class Square : Shape
{
    void Shape.Draw()
    {
        Console.WriteLine("Square::draw()");
    }
}

public class Circle : Shape
{
    void Shape.Draw()
    {
        Console.WriteLine("Circle::draw()");
    }
}