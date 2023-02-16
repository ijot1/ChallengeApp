string name;
int age;
int limit = 30;
char sex;

name = "Greta";
age = 28;
sex = 'F';
if (sex == 'F' && age < limit)
{
    Console.WriteLine("\"" + "Kobieta poniżej " + limit + " lat" + "\"");
}

name = "Ewa";
age = 33;
sex = 'F';
if (name == "Ewa" && sex == 'F')
{ 
    Console.WriteLine("\"" + name + ", lat " + age + "\"");
}


name = "Adam";
age = 17;
sex = 'M';
if (sex =='M' && age < 18)
{
    Console.WriteLine("\"" + "Niepełnoletni mężczyzna" + "\"");
}

