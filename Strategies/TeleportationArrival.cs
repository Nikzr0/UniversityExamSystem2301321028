namespace UniversityExamSystem2301321028;

public sealed class TeleportationArrival : IArrivalStrategy
{
    public void Arrive(string studentName)
    {
        Console.WriteLine($"{studentName} arrived instantly by teleportation.");
    }
}
