namespace UniversityExamSystem2301321028;

public class BaseStudent : IStudent
{
    private IArrivalStrategy _arrivalStrategy;

    public BaseStudent(string name, StudentType studentType)
    {
        Name = name;
        StudentType = studentType;
        _arrivalStrategy = new SkippingArrival();
    }

    public string Name { get; }
    public StudentType StudentType { get; }

    public void SetArrivalStrategy(IArrivalStrategy strategy)
    {
        _arrivalStrategy = strategy;
    }

    public void Arrive()
    {
        _arrivalStrategy.Arrive(Name);
    }

    public virtual void TakeExam(ITask task)
    {
        Console.WriteLine($"{Name} started the exam. Task: {task.GetDescription()}");
        Console.WriteLine($"{Name} finished the exam.");
    }
}
