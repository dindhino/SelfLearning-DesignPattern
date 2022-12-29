// See https://aka.ms/new-console-template for more information
ComputerPart computer = new Computer();
computer.Accept(new ComputerPartDisplayVisitor());

Console.ReadLine();
