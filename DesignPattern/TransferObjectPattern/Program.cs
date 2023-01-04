// See https://aka.ms/new-console-template for more information
StudentBO studentBusinessObject = new StudentBO();

foreach (StudentVO studentVO in studentBusinessObject.getAllStudents())
    Console.WriteLine("Student: [RollNo : " + studentVO.GetRollNo() + ", Name : " + studentVO.GetName() + " ]");

StudentVO student = studentBusinessObject.getAllStudents()[0];
student.SetName("Michael");
studentBusinessObject.UpdateStudent(student);

student = studentBusinessObject.GetStudent(0);
Console.WriteLine("Student: [RollNo : " + student.GetRollNo() + ", Name : " + student.GetName() + " ]");

Console.ReadLine();