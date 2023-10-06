// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());

int NumberSum(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }

    return sum;
}

int numberSum = NumberSum(number);
Console.WriteLine($"The sum of the digits in the {number} -> {numberSum}");
