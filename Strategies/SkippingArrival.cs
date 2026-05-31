namespace UniversityExamSystem2301321028;

public sealed class SkippingArrival : IArrivalStrategy
{
    public void Arrive(string studentName)
    {
        Console.WriteLine($"{studentName} arrived by skipping across campus.");
    }
}
