// See https://aka.ms/new-console-template for more information
StudentDao studentDao = new StudentDaoImpl();

foreach (Student student in studentDao.GetAllStudents())
{
    Console.WriteLine("Student: [RollNo : " + student.GetRollNo() + ", Name : " + student.GetName() + " ]");
}

Student selectedStudent = studentDao.GetAllStudents()[0];
selectedStudent.SetName("Michael");
studentDao.UpdateStudent(selectedStudent);

studentDao.GetStudent(0);
Console.WriteLine("Student: [RollNo : " + selectedStudent.GetRollNo() + ", Name : " + selectedStudent.GetName() + " ]");

Console.ReadLine();