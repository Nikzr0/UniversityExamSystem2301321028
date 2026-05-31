namespace UniversityExamSystem2301321028;

public interface IStudent
{
    string Name { get; }
    StudentType StudentType { get; }
    void SetArrivalStrategy(IArrivalStrategy strategy);
    void Arrive();
    void TakeExam(ITask task);
}
