using ChallengeApp;

var employee = new Employee("Ala", "Makota");

float valueOfFloat = 99.1F;
employee.AddGrade(valueOfFloat);

string valueOfString = "105";
employee.AddGrade(valueOfString);

string valueOfString2 = "85";
employee.AddGrade(valueOfString2);

string valueOfString3 = "Ala ma";
employee.AddGrade(valueOfString3);

char valueOfChar = 'Z';
employee.AddGrade(valueOfChar);

char valueOfChar2 = 'e';
employee.AddGrade(valueOfChar2);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average, 5:F2}");
Console.WriteLine($"Min: {statistics.Min, 9:F2}");
Console.WriteLine($"Max: {statistics.Max, 9:F2}");