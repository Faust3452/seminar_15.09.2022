﻿// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    int n1 = -n;
    do 
    {
        Console.Write($"{n1}, ");
        n1++;
    }
    while (n1 < (n+1));
}
else
{
    int n1 = -n;
    do 
    {
        Console.Write($"{n}, ");
        n++;
    }
    while (n < (n1+1));    
}