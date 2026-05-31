namespace UniversityExamSystem2301321028;

public sealed class TelepathyDecorator : StudentSuperpowerDecorator
{
    public TelepathyDecorator(IStudent student) : base(student)
    {
    }

    public override void TakeExam(ITask task)
    {
        Console.WriteLine($"{Name} uses telepathy to understand the questions instantly.");
        base.TakeExam(task);
    }
}
