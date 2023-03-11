using ChallengeApp;

var employee = new Employee("Ala", "Makota");
var rand = new Random();
int gradesNumber = 5;
int count = 0;
float grade;

for(int i = 0; i < gradesNumber; i++)
{
    grade = (float)(10 * rand.NextDouble());
    employee.AddGrade(grade);
    count++;
    Console.WriteLine($"grade [{count}] = {grade, 5:F2}");
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average, 5:F2}");
Console.WriteLine($"Min: {statistics.Min, 9:F2}");
Console.WriteLine($"Max: {statistics.Max, 9:F2}");
Console.WriteLine (System.IO.Path.DirectorySeparatorChar);