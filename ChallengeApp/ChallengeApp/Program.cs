string name;
int age;
int limit = 30;
int limit1 = 18;
char sex;

name = "Ewa";
age = 18;
sex = 'F';

if (sex == 'F' && age < limit)
{
    Console.WriteLine("\"" + "Kobieta poniżej " + limit + " lat" + "\"");
}
else if (name == "Ewa" && sex == 'F')
{ 
    Console.WriteLine("\"" + name + ", lat " + age + "\"");
}
else if (sex == 'M' && age < limit1)
{
    Console.WriteLine("\"" + "Niepełnoletni mężczyzna" + "\"");
}
else if (age >= limit1)
{
    Console.WriteLine("\"" + "Osoba jest pełnoletnia" + "\"");
}
