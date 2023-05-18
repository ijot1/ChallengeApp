using ChallengeApp;

var employee = new EmployeeInFile("Ala", "Makota");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("dodano nową ocenę");
}

Console.WriteLine("Witaj w programie do oceny pracowników");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine($"Podaj ocenę z zakresu: {EmployeeInFile.lowestGrade} - {EmployeeInFile.highestGrade};");
Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine("Oceniając pracowników możesz podać ocenę w postaci litery:");
Console.WriteLine("Pracownicy:");
Console.WriteLine(  $"A ={EmployeeInFile.levelA,3}; " +
                    $"B ={EmployeeInFile.levelB,3}; " +
                    $"C ={EmployeeInFile.levelC,3}; " +
                    $"D ={EmployeeInFile.levelD,3}; " +
                    $"E ={EmployeeInFile.levelE,2}\n");

Console.WriteLine($"{employee.GetName()}");
Console.WriteLine();

string? input = "";
while (true)
{
    Console.WriteLine($"Podaj ocenę z zakresu: {EmployeeInFile.lowestGrade} - {EmployeeInFile.highestGrade}; q: zakończ");
            
    input = Console.ReadLine();
    if (input != "q")
    {
        Console.WriteLine($"Podałeś ocenę: {input}");
        try
        {
            //employee.AddGrade(input);
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
        Console.WriteLine("--------------");
        break;
    }
    
}

Console.WriteLine($"Pracownik: {employee.GetName()}");
var statistics = employee.GetStatistics();

Console.WriteLine($"Letter: {statistics.AverageLetter,6:F2}");
Console.WriteLine("--------------");
Console.WriteLine($"Average: {statistics.Average,5:F2}");
Console.WriteLine($"Min: {statistics.Min,9:F2}"); 
Console.WriteLine($"Max: {statistics.Max,9:F2}");
