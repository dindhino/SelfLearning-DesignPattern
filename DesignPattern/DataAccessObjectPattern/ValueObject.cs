public class Student
{
    private string name;
    private int rollNo;

    public Student(string name, int rollNo)
    {
        this.name = name;
        this.rollNo = rollNo;
    }

    public string GetName() => name;
    public void SetName(string name) => this.name = name;
    public int GetRollNo() => rollNo;
    public void SetRollNo(int rollNo) => this.rollNo = rollNo;
}