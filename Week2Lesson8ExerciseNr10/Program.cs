Console.WriteLine("enter first number");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("enter second number");
int number2 = int.Parse(Console.ReadLine());
int biggerNumber = 0;
if (number1 >= number2)
{
    biggerNumber = number1;
}
else if (number1 <= number2)
{
    biggerNumber = number2;
}
for (int i = biggerNumber; i >= biggerNumber; i++)
{
    if ((number1 > number2 || number1 < number2 )&& i % number1 == 0 && i % number2 == 0)
    {
        Console.WriteLine($"The least common multiple is:{i}");
        break;
    }
    else if (number1 == number2)
    {
        Console.WriteLine("you have to write 2 different numbers");
        break;
    }
}
