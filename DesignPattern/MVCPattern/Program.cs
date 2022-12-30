// See https://aka.ms/new-console-template for more information
Student model = RetriveStudentFromDatabase();

Student RetriveStudentFromDatabase()
{
    Student student = new Student();
    student.SetName("Robert");
    student.SetRollNo("10");
    return student;
}

StudentView view = new StudentView();

StudentController controller = new StudentController(model, view);

controller.UpdateView();

controller.SetStudentName("John");

controller.UpdateView();

Console.ReadLine();