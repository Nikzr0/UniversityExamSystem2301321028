namespace UniversityExamSystem2301321028;

public sealed class TaskFactory
{
    public ITask CreateTask(StudentType studentType)
    {
        return studentType switch
        {
            StudentType.Wunderkind => new FunTask(),
            StudentType.FitnessManiac => new IncomprehensibleTask(),
            StudentType.Kalitko => new EasyTask(),
            _ => throw new ArgumentOutOfRangeException(nameof(studentType), studentType, "Unknown student type")
        };
    }
}
