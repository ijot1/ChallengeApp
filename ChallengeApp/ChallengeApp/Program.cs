using ChallengeApp;

List<Employee> employees = new List<Employee>()
{
    new Employee("Irena", "Janik"),
    new Employee("Jan", "Kranik"),
    new Employee("Karol", "Lanik")
};

//
int evalNumber = 5;
var randEval = new Random();
//
for (int i = 0; i < evalNumber; i++)
{
    foreach (Employee e in employees)
    {
        e.AddEvaluation(randEval.Next(1, 11));
    }
}

foreach (Employee e in employees)
{
    Console.WriteLine(e.FirstName + " " + e.LastName + "; " + e.Result); ;
}

int maxResult = -1;
Employee empHighestEval = null;

foreach (Employee e in employees)
{
    if (e.Result > maxResult)
    {
        maxResult = e.Result;
        empHighestEval = e;
    }
}

foreach (Employee e in employees)
{
    if (e.Result == maxResult)
    {
        Console.WriteLine(
            "\nThe highest evaluated employee: \n" 
            + e.FirstName + " " 
            + e.LastName + "; " 
            + "eval = " + maxResult);

    }
}


