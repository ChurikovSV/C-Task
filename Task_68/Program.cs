﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int M = 2;
int N = 3;

int AckermanFunctions(int m, int n)
{
    if(m == 0) return n + 1;
    else if(n == 0 && m > 0) return AckermanFunctions(m - 1, 1);
    else return (AckermanFunctions(m - 1, AckermanFunctions(m, n - 1)));
}

Console.WriteLine(AckermanFunctions(M, N));
