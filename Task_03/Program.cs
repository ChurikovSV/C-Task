// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter number: ");
int Number = Convert.ToInt32(Console.ReadLine());

if ((Number % 2) == 0)
{
    Console.Write($"{Number} - четное число");
}
else
{
    Console.Write($"{Number} - нечетное число");
}