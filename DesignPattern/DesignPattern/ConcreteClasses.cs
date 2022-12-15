public class Circle : Shape
{
    void Shape.Draw()
    {
        Console.WriteLine("Inside Circle::draw() method.");
    }
}

public class Rectangle : Shape
{
    void Shape.Draw()
    {
        Console.WriteLine("Inside Rectangle::draw() method.");
    }
}

public class Square : Shape
{
    void Shape.Draw()
    {
        Console.WriteLine("Inside Square::draw() method.");
    }
}
