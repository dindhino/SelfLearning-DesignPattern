public interface StudentDao
{
    public List<Student> GetAllStudents();
    public Student GetStudent(int rollNo);
    public void UpdateStudent(Student student);
    public void DeleteStudent(Student student);
}