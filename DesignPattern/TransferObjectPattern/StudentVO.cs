public class StudentVO
{
    private String name;
    private int rollNo;

    public StudentVO(String name, int rollNo)
    {
        this.name = name;
        this.rollNo = rollNo;
    }

    public String GetName() => name;

    public void SetName(String name) => this.name = name;

    public int GetRollNo() => rollNo;

    public void SetRollNo(int rollNo) => this.rollNo = rollNo;
}