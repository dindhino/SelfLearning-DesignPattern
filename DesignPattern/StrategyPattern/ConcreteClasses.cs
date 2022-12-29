public class OperationAdd : Strategy
{
    int Strategy.DoOperation(int num1, int num2) => num1 + num2;
}

public class OperationSubstract : Strategy
{
    int Strategy.DoOperation(int num1, int num2) => num1 - num2;
}

public class OperationMultiply : Strategy
{
    int Strategy.DoOperation(int num1, int num2) => num1 * num2;
}