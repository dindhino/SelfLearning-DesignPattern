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

public class RoundedRectangle : Shape
{
    void Shape.Draw()
    {
        Console.WriteLine("Inside RoundedRectangle::draw() method.");
    }
}

public class RoundedSquare : Shape
{
    void Shape.Draw()
    {
        Console.WriteLine("Inside RoundedSquare::draw() method.");
    }
}