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

int maxResult = 0;
Employee empHighestEval = null;

foreach (Employee e in employees)
{
    if (e.Result > maxResult)
    {
        empHighestEval = e;
    }
}

Console.WriteLine("\nThe highest evaluated employee: \n" + empHighestEval.FirstName + empHighestEval.LastName + "eval = " + empHighestEval.Result);


