using ChallengeApp;

var employee = new Employee("Ala", "Makota");

Console.WriteLine("Witaj w programie do oceny pracowników");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine($"{employee.Name} {employee.Surname}");
Console.WriteLine();

var input = "";
while (true)
{
    Console.WriteLine("Podaj ocenę: 0 - 100; 'q': zakończ");
    input = Console.ReadLine();
    if (input != "q")
    {
        Console.WriteLine($"Podałeś ocenę: {input}");
        employee.AddGrade(input);
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"liczba ocen: {employee.GradesCount()}");
        Console.WriteLine();
        Console.WriteLine($"Pracownik: {employee.Name} {employee.Surname}");
        Console.WriteLine("--------------");
        break;
    }
    
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Letter: {statistics.AverageLetter,6:F2}");
Console.WriteLine("--------------");
Console.WriteLine($"Average: {statistics.Average,5:F2}");
Console.WriteLine($"Min: {statistics.Min,9:F2}");
Console.WriteLine($"Max: {statistics.Max,9:F2}");
