// Exercise Check if Palindrome

//Console.Clear();

System.Console.WriteLine("Hello and welcome to the Palindrome Program!");
int number;
do
{
    System.Console.Write("Please enter your Number: ");
    number = int.Parse(Console.ReadLine()!);
}
while (number < 0);

int reverseNumber = 0;
int count = number.ToString().Length;
int testNumber = number;

for (int i = 1; i < count + 1; i++)
{
    double test = testNumber % 10;
    reverseNumber *= 10;
    reverseNumber += (int)test;
    testNumber /= 10;
}

if (number == reverseNumber)
{
    System.Console.WriteLine($"You number {number} is a Palindrome!");
}
else
{
    System.Console.WriteLine($"You number {number} is not a Palindrome!");
}

int test1;
int count1;
int TestNumber1;
int reverseNumber1 = 0;
int biggerPalindrome = 0;
for (int i = 1; i < 1000; i++)
{
    for (int j = 0; j < 1000; j++)
    {


        test1 = i * j;
        count1 = test1.ToString().Length;
        TestNumber1 = test1;
        reverseNumber1 = 0;
        for (int k = 1; k < count1 + 1; k++)
        {
            double test2 = TestNumber1 % 10;
            reverseNumber1 *= 10;
            reverseNumber1 += (int)test2;
            TestNumber1 /= 10;
        }
        if (reverseNumber1 == test1)
        {
            if (test1 >= biggerPalindrome)
            {
                biggerPalindrome = test1;
            }
        }
    }
}
System.Console.WriteLine($"The bigger Palindrome of 3-digit Numbers is {biggerPalindrome}");