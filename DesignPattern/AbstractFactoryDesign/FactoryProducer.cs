public class FactoryProducer
{
    public static AbstractFactory getFactory(bool isRounded)
    {
        if (isRounded)
        {
            return new RoundedShapeFactory();
        }
        else
        {
            return new ShapeFactory();
        }
    }
}