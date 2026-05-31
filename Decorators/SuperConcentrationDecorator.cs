namespace UniversityExamSystem2301321028;

public sealed class SuperConcentrationDecorator : StudentSuperpowerDecorator
{
    public SuperConcentrationDecorator(IStudent student) : base(student)
    {
    }

    public override void TakeExam(ITask task)
    {
        Console.WriteLine($"{Name} activates super concentration.");
        base.TakeExam(task);
    }
}
