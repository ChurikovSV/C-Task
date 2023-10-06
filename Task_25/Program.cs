// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Enter the first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int NaturalDegree(int num1, int num2)
{   
    int i = 1;
    int result = num1;

    while (i < num2)
    {
        result = result * num1;
        i++;
    }

    return result;
}

int naturalDegree = NaturalDegree(firstNumber, secondNumber);
Console.WriteLine($"The number {firstNumber} to the natural power of {secondNumber} -> {naturalDegree}");
