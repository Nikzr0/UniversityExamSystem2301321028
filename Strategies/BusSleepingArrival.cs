namespace UniversityExamSystem2301321028;

public sealed class BusSleepingArrival : IArrivalStrategy
{
    public void Arrive(string studentName)
    {
        Console.WriteLine($"{studentName} arrived after falling asleep on the bus.");
    }
}
