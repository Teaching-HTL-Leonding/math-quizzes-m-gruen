// Fizz Buzz exercises

Console.Clear();
System.Console.WriteLine("Welcome to the Fizz Buzz Program!");
System.Console.Write("Please enter the Number which will be counted from 1 to the number: ");
int n = int.Parse(System.Console.ReadLine()!);
System.Console.Write("Please enter th Number for Fizz: ");
int a = int.Parse(System.Console.ReadLine()!);
System.Console.Write("Please enter th Number for Buzz: ");
int b = int.Parse(System.Console.ReadLine()!);

for (int i = 1; i <= n; i++)
{
    if (i % a == 0 && i % b == 0)
    {
        System.Console.Write("FizzBuzz ");
    }
    else if (i % a == 0)
    {
        System.Console.Write("Fizz ");
    }
    else if (i % b == 0)
    {
        System.Console.Write("Buzz ");
    }
    else 
    {
        System.Console.Write($"{i} ");
    }
}