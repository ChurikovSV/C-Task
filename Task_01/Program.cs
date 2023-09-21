// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter the first number: ");
int NumberFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int NumberSecond = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (NumberFirst > NumberSecond) max = NumberFirst;
if (NumberSecond > NumberFirst) max = NumberSecond;
if (NumberSecond == NumberFirst) 
{
    Console.WriteLine("Both numbers are equal");
}
else 
{
    Console.Write("max = ");
    Console.WriteLine(max);
}
