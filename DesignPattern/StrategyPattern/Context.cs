﻿public class Context
{
    private Strategy strategy;
    public Context(Strategy strategy) => this.strategy = strategy;
    public int ExecuteStrategy(int num1, int num2) => strategy.DoOperation(num1, num2);
}