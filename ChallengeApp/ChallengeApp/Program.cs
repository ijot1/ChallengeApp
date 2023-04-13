using ChallengeApp;

var employee = new Employee("Ala", "Makota", 'F');

Console.WriteLine("Witaj w programie do oceny pracowników");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine($"Podaj ocenę z zakresu: {Employee.lowestGrade} - {Employee.highestGrade};");
Console.WriteLine("Możesz podać ocenę w postaci litery:");
Console.WriteLine(  $"A ={Employee.levelA,3}; " +
                    $"B ={Employee.levelB,3}; " +
                    $"C ={Employee.levelC,3}; " +
                    $"D ={Employee.levelD,3}; " +
                    $"E ={Employee.levelE,2}\n");
Console.WriteLine($"{employee.GetName()}");
Console.WriteLine();

string? input = "";
while (true)
{
    Console.WriteLine($"Podaj ocenę z zakresu: {Employee.lowestGrade} - {Employee.highestGrade}; q: zakończ");
            
    input = Console.ReadLine();
    if (input != "q")
    {
        Console.WriteLine($"Podałeś ocenę: {input}");
        try
        {
            employee.AddGrade(input);
        }
        catch(Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
        
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"liczba ocen: {employee.GradesCount()}");
        Console.WriteLine();
        Console.WriteLine($"Pracownik: {employee.GetName()}");
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
