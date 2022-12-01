// Hailstone Sequence

Console.Clear();

System.Console.WriteLine("Hello and welcome to the Hailstone Sequence program!");
int first;
do
{
    System.Console.Write("Please enter your first Number: ");
    first = int.Parse(Console.ReadLine()!);
}
while (first <= 0);

int second;
do
{
    System.Console.Write("Please enter your second Number: ");
    second = int.Parse(Console.ReadLine()!);
}
while (second <= 0);

int testFirst = first;
int testSecond = second;

int countFirst = 0;
do
{
    if (first % 2 == 0)
    {
        first /= 2;
    }
    else
    {
        first *= 3;
        first += 1;
    }
    countFirst++;
}
while (first != 1);

int countSecond = 0;
do
{
    if (second % 2 == 0)
    {
        second /= 2;
    }
    else
    {
        second *= 3;
        second += 1;
    }
    countSecond++;
}
while (second != 1);

if (countFirst >= countSecond)
{
    System.Console.WriteLine($"Your First Number {testFirst} has a longer Hailstone Sequence!");
}
else
{
    System.Console.WriteLine($"Your Second Number {testSecond} has a longer Hailstone Sequence!");
}
