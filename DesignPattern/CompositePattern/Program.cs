// See https://aka.ms/new-console-template for more information
Employee CEO = new Employee("John", "CEO", 30000);

Employee headSales = new Employee("Robert", "Head Sales", 20000);

Employee headMarketing = new Employee("Michel", "Head Marketing", 20000);

Employee clerk1 = new Employee("Laura", "Marketing", 10000);
Employee clerk2 = new Employee("Bob", "Marketing", 10000);

Employee salesExecutive1 = new Employee("Richard", "Sales", 10000);
Employee salesExecutive2 = new Employee("Rob", "Sales", 10000);

CEO.Add(headSales);
CEO.Add(headMarketing);

headSales.Add(salesExecutive1);
headSales.Add(salesExecutive2);

headMarketing.Add(clerk1);
headMarketing.Add(clerk2);

Console.WriteLine(CEO.toString());
foreach(Employee headEmployee in CEO.GetSubordinates())
{
    Console.WriteLine("->" + headEmployee.toString());

    foreach(Employee employee in headEmployee.GetSubordinates())
    {
        Console.WriteLine("->->" + employee.toString());
    }
}

Console.ReadLine();