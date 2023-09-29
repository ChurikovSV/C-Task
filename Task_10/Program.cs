// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Enter a number from 100 to 999: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99)
{
    int Digit(int num)
  {
      int fDigit = num / 10;
      int sDigit = fDigit % 10;
      return sDigit;
  } 
  int result = Digit(number);
  Console.WriteLine($"number = {result}");

}
else 
{
  Console.WriteLine($"You entered an incorrect number");
}