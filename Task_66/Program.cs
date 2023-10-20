// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Enter the number M - ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number N - ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM <= 0 || numberN <= 0) //Проверка на натуальность числа 
{
    Console.Write("Input error"); 
    return;
}

int SumNatureNumbers(int m, int n)
{
    if (m == n) return m;
    else if (m < n) return n + SumNatureNumbers(m, n - 1);
    else return n + SumNatureNumbers(m, n + 1);
}

Console.WriteLine(SumNatureNumbers(numberM, numberN));
