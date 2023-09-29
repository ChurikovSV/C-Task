// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    int Digit(int num)
    {
        while (num > 999)
        {
            num /= 10;
        }
        return num % 10;
    }
    int result = Digit(number);
    Console.WriteLine($"number = {result}");
}
else 
{
    Console.WriteLine($"You entered an incorrect number");
}