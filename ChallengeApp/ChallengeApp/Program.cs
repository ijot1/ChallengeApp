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

var statistics1 = employee.GetStatisticsWithFor();
Console.WriteLine($"AverageFor: {statistics1.Average,5:F2}");
Console.WriteLine($"MinFor: {statistics1.Min,9:F2}");
Console.WriteLine($"MaxFor: {statistics1.Max,9:F2}");

var statistics2= employee.GetStatisticsWithDoWhile();
Console.WriteLine($"AverageDoWhile: {statistics2.Average,5:F2}");
Console.WriteLine($"MinDoWhile: {statistics2.Min,9:F2}");
Console.WriteLine($"MaxDoWhile: {statistics2.Max,9:F2}");

var statistics3 = employee.GetStatisticsWithWhile();
Console.WriteLine($"AverageWhile: {statistics3.Average,5:F2}");
Console.WriteLine($"MinWhile: {statistics3.Min,9:F2}");
Console.WriteLine($"MaxWhile: {statistics3.Max,9:F2}");