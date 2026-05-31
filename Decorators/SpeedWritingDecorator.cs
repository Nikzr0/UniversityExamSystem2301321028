namespace UniversityExamSystem2301321028;

public sealed class SpeedWritingDecorator : StudentSuperpowerDecorator
{
    public SpeedWritingDecorator(IStudent student) : base(student)
    {
    }

    public override void TakeExam(ITask task)
    {
        Console.WriteLine($"{Name} uses speed writing to answer quickly.");
        base.TakeExam(task);
    }
}
