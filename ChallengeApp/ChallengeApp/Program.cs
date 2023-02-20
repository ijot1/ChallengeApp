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

string[] empName = new string[employees.Count];
int[] empResult = new int[employees.Count];
int count = 0;

foreach (Employee e in employees)
{
    empName[count] = e.FirstName + " " + e.LastName + "; ";
    empResult[count] = e.Result;
    count++;
    Console.WriteLine(e.FirstName + " " + e.LastName + "; " + "eval = " + e.Result);
}

int maxIndex = 0;
int max = empResult[maxIndex];

for (int i = 1; i < employees.Count; i++)
{
    if (max <= empResult[i])
    {
        max = empResult[i];
        maxIndex = i;
    }
    else
        continue;
}

Console.WriteLine("\nThe highest evaluated employee: \n" + empName[maxIndex] + "eval = " + empResult[maxIndex]);


