// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter the first number: ");
int NumberFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int NumberSecond = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third number:: ");
int NumberThree = Convert.ToInt32(Console.ReadLine());

int max = NumberFirst;

if (NumberFirst > max) max = NumberFirst;
if (NumberSecond > max) max = NumberSecond;
if (NumberThree >  max) max = NumberThree;

Console.Write($"max = {max}");