public class StudentController
{
    private Student model;
    private StudentView view;

    public StudentController(Student model, StudentView view)
    {
        this.model = model;
        this.view = view;
    }

    public void SetStudentName(String name)
    {
        model.SetName(name);
    }

    public String GetStudentName()
    {
        return model.GetName();
    }

    public void SetStudentRollNo(String rollNo)
    {
        model.SetRollNo(rollNo);
    }

    public String GetStudentRollNo()
    {
        return model.GetRollNo();
    }

    public void UpdateView()
    {
        view.PrintStudentDetails(model.GetName(), model.GetRollNo());
    }
}