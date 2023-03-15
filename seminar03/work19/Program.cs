// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using System;

void Polindrom(int number)
{
    int N1 = number / 10000;
    int N2 = (number / 1000) % 10;
    int N3 = (number % 100) / 10;
    int N4 = number % 10;
    if (N1 == N4 && N2 == N3)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}





Polindrom(14212);