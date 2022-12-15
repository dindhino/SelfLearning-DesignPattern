public class VegBurger : Burger
{
    public override string Name() => "Veg Burger";

    public override float Price() => 25.0f;
}

public class ChickenBurger : Burger
{
    public override string Name() => "Chicken Burger";

    public override float Price() => 50.0f;
}

public class Coke : ColdDrink
{
    public override string Name() => "Coke";

    public override float Price() => 30.0f;
}

public class Pepsi : ColdDrink
{
    public override string Name() => "Pepsi ";

    public override float Price() => 35.0f;
}