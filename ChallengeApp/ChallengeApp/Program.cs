using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

int number = int.MaxValue;
//
char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();
//
int[] result = new int[digits.Length];

for (int j = 0; j < letters.Length; j++)
{
    for (int i = 0; i < digits.Length; i++)
    {
        if (letters[j] == digits[i])
        {
            result[i]++;
        }
        
    }
}
Console.WriteLine("number = " + number);
for (int i = 0; i < digits.Length; i++)
{
    Console.WriteLine("digit " + "\"" + digits[i] + "\"" + " -> " + result[i]);
}