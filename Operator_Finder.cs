// Some Practices

Console.Clear();

System.Console.WriteLine("Welcome to the Operator Findings System!");
System.Console.Write("Pls enter your First Number: ");
double firstNumber = double.Parse(Console.ReadLine()!);
System.Console.Write("Pls enter your Second Number: ");
double secondNumber = double.Parse(Console.ReadLine()!);
System.Console.Write("Pls enter your Result: ");
double result = Math.Round(double.Parse(Console.ReadLine()!), 2);

char operator1;
if (firstNumber + secondNumber == result) { operator1 = '+'; }
else if (firstNumber - secondNumber == result || secondNumber - firstNumber == result) { operator1 = '-'; }
else if (Math.Round(firstNumber / secondNumber, 2) == result || Math.Round(secondNumber / firstNumber, 2) == result) { operator1 = '/'; }
else if (firstNumber * secondNumber == result) { operator1 = '*'; }
else if (firstNumber % secondNumber == result || secondNumber % firstNumber == result) { operator1 = '%'; }
else if (Math.Pow(firstNumber, secondNumber) == result || Math.Pow(secondNumber, firstNumber) == result) { operator1 = '^'; }
else { operator1 = ' '; }

string operator2 = operator1 switch
{
    '+' => "Plus",
    '-' => "Minus",
    '/' => "Divide",
    '*' => "Multiply",
    '%' => "Modulo",
    '^' => "Exponentiation",
    _ => "unknown"
};

System.Console.WriteLine($"Your operation was {operator2}");