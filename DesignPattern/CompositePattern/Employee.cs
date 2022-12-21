public class Employee
{
    private string name;
    private string dept;
    private int salary;
    private List<Employee> subordinates;

    public Employee(string name, string dept, int salary)
    {
        this.name = name;
        this.dept = dept;
        this.salary = salary;
        subordinates = new List<Employee>();
    }

    public void Add(Employee employee)
    {
        subordinates.Add(employee);
    }

    public void Remote(Employee employee)
    {
        subordinates.Remove(employee);
    }

    public List<Employee> GetSubordinates()
    {
        return subordinates;
    }

    public string toString()
    {
        return ("Employee :[ Name : " + name 
				+ ", dept : " + dept + ", salary :" + salary + " ]");
    }
}