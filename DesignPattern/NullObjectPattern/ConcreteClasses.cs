public class RealCustomer : AbstractCustomer
{
    public RealCustomer(string name) => this.name = name;
    public override string GetName() => name;
    public override bool isNil() => false;
}

public class NullCustomer : AbstractCustomer
{
    public override string GetName() => "Not Available in Customer Database";
    public override bool isNil() => true;
}