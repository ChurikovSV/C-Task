// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreatArrayRbdDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToDouble(rnd.Next(min, max + 1)) / 100;
    }

    return arr;
}


void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]:F2}, ");
        else Console.Write($"{arr[i]:F2}");
    }
}


double MaximumEl(double[] arr)
{
    double max = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }

    return max;
}


double MinimumEl(double[] arr)
{
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }

    return min;
}



double[] array = CreatArrayRbdDouble(5, 1000, 10000);
double max = MaximumEl(array);
double min = MinimumEl(array);


Console.Write($"[");
PrintArray(array);
Console.WriteLine($"] => {max:F2} - {min:F2} = {max - min:F2}");
