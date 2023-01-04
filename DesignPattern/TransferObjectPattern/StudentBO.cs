public class StudentBO
{
    List<StudentVO> students;

    public StudentBO()
    {
        students = new List<StudentVO>();
        StudentVO student1 = new StudentVO("Robert", 0);
        StudentVO student2 = new StudentVO("John", 1);
        students.Add(student1);
        students.Add(student2);
    }
    public void DeleteStudent(StudentVO student)
    {
        students.RemoveAll(x => x.GetRollNo() == student.GetRollNo());
        Console.WriteLine("Student: Roll No " + student.GetRollNo() + ", deleted from database");
    }

    public List<StudentVO> getAllStudents() => students;

    public StudentVO GetStudent(int rollNo) => JustGetStudent(rollNo);

    private StudentVO JustGetStudent(int rollNo) => students.FirstOrDefault(x => x.GetRollNo() == rollNo);

    public void UpdateStudent(StudentVO student)
    {
        StudentVO selectedStudent = JustGetStudent(student.GetRollNo());
        if (selectedStudent != null)
            selectedStudent.SetName(student.GetName());
        Console.WriteLine("Student: Roll No " + student.GetRollNo() + ", updated in the database");
    }
}