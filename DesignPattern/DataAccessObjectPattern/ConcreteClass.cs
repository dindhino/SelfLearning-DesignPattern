public class StudentDaoImpl : StudentDao
{
    List<Student> students;

    public StudentDaoImpl()
    {
        students = new List<Student>();
        Student student1 = new Student("Robert", 0);
        Student student2 = new Student("John", 1);
        students.Add(student1);
        students.Add(student2);
    }

    void StudentDao.DeleteStudent(Student student)
    {
        students.RemoveAt(student.GetRollNo());
        Console.WriteLine("Student: Roll No " + student.GetRollNo() + ", deleted from database");
    }

    List<Student> StudentDao.GetAllStudents() => students;

    Student StudentDao.GetStudent(int rollNo) => students[rollNo];

    void StudentDao.UpdateStudent(Student student)
    {
        students[student.GetRollNo() ].SetName(student.GetName());
        Console.WriteLine("Student: Roll No " + student.GetRollNo() + ", updated in the database");
    }
}