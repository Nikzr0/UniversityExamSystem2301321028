namespace UniversityExamSystem2301321028;

public sealed class University
{
    private static readonly Lazy<University> InstanceLazy = new(() => new University());
    public static University Instance => InstanceLazy.Value;

    private readonly TaskFactory _taskFactory = new();

    private University()
    {
    }

    public ITask CreateTask(StudentType studentType)
    {
        return _taskFactory.CreateTask(studentType);
    }

    public void ConductExam(IStudent student)
    {
        var task = CreateTask(student.StudentType);
        student.TakeExam(task);
    }
}
