using UniversityExamSystem2301321028;

var university = University.Instance;

IStudent wunderkind = new BaseStudent("Elena", StudentType.Wunderkind);
IStudent fitnessManiac = new BaseStudent("Viktor", StudentType.FitnessManiac);
IStudent kalitko = new BaseStudent("Mira", StudentType.Kalitko);

wunderkind.SetArrivalStrategy(new TeleportationArrival());
fitnessManiac.SetArrivalStrategy(new BusSleepingArrival());
kalitko.SetArrivalStrategy(new SkippingArrival());

wunderkind.Arrive();
fitnessManiac.Arrive();
kalitko.Arrive();

wunderkind = new SuperConcentrationDecorator(wunderkind);
fitnessManiac = new SpeedWritingDecorator(new TelepathyDecorator(fitnessManiac));

var wunderkindTask = university.CreateTask(wunderkind.StudentType);
var fitnessTask = university.CreateTask(fitnessManiac.StudentType);
var kalitkoTask = university.CreateTask(kalitko.StudentType);

wunderkind.TakeExam(wunderkindTask);
fitnessManiac.TakeExam(fitnessTask);
kalitko.TakeExam(kalitkoTask);
