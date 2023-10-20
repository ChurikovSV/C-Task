﻿// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
     int temp = 2;
     int i = 1;
     while(i < N + 1)
     {
       temp = i * i * i;
       Console.WriteLine($"{temp}");
       i++;
     }
     
        
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 5;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}