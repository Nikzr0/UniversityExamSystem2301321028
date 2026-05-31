namespace UniversityExamSystem2301321028;

public abstract class StudentSuperpowerDecorator : IStudent
{
    protected StudentSuperpowerDecorator(IStudent student)
    {
        Student = student;
    }

    protected IStudent Student { get; }

    public string Name => Student.Name;
    public StudentType StudentType => Student.StudentType;

    public void SetArrivalStrategy(IArrivalStrategy strategy)
    {
        Student.SetArrivalStrategy(strategy);
    }

    public void Arrive()
    {
        Student.Arrive();
    }

    public virtual void TakeExam(ITask task)
    {
        Student.TakeExam(task);
    }
}
