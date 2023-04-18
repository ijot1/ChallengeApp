using ChallengeApp;

//var employee = new Employee("Ala", "Makota");
var supervisor = new Supervisor("Ala", "Makota", "kierownik");

Console.WriteLine("Witaj w programie do oceny pracowników");
Console.WriteLine("======================================");
Console.WriteLine();
Console.WriteLine($"Podaj ocenę z zakresu: {Employee.lowestGrade} - {Employee.highestGrade};");
Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine("Oceniając pracowników możesz podać ocenę w postaci litery:");
Console.WriteLine("Pracownicy:");
Console.WriteLine(  $"A ={Employee.levelA,3}; " +
                    $"B ={Employee.levelB,3}; " +
                    $"C ={Employee.levelC,3}; " +
                    $"D ={Employee.levelD,3}; " +
                    $"E ={Employee.levelE,2}\n");
Console.WriteLine("Oceniając kadrę kierowniczą możesz podać ocenę w postaci cyfry od 1 do 6");
Console.WriteLine("lub cyfry ze znakiem: '+' podwyższa, '-' obniża ocenę o 5");
Console.WriteLine("Kierownicy:");
Console.WriteLine(  $"'{Supervisor.mark6}' - {Supervisor.grade6,2}; " +
                    $"'{Supervisor.mark5}' - {Supervisor.grade5,2}; " +
                    $"'{Supervisor.mark4}' - {Supervisor.grade4,2}; " +
                    $"'{Supervisor.mark3}' - {Supervisor.grade3,2}; " +
                    $"'{Supervisor.mark2}' - {Supervisor.grade2,2}; " +
                    $"'{Supervisor.mark1}' - {Supervisor.grade1,1};\n");
                    
//Console.WriteLine($"{employee.GetName()}");
Console.WriteLine($"{supervisor.GetName()}");
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
            //employee.AddGrade(input);
            supervisor.AddGrade(input);
        }
        catch(Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
        
    }
    else
    {
        Console.WriteLine();
        //Console.WriteLine($"liczba ocen: {employee.GradesCount()}");
        Console.WriteLine($"liczba ocen: {supervisor.GradesCount()}");
        Console.WriteLine();
        //Console.WriteLine($"Pracownik: {employee.GetName()}");
        Console.WriteLine($"Pracownik: {supervisor.GetName()}");
        Console.WriteLine("--------------");
        break;
    }
    
}

//var statistics = employee.GetStatistics();
var statistics = supervisor.GetStatistics();

Console.WriteLine($"Letter: {statistics.AverageLetter,6:F2}");
Console.WriteLine("--------------");
Console.WriteLine($"Average: {statistics.Average,5:F2}");
Console.WriteLine($"Min: {statistics.Min,9:F2}");
Console.WriteLine($"Max: {statistics.Max,9:F2}");
