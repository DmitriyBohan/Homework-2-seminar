/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Напишите трехзначное число, а я покажу его вторую цифру");
int Number = Convert.ToInt32(Console.ReadLine());
int SecondNumber = Number / 10 % 10;
Console.WriteLine($"у вашего числа {Number} вторая цифра это {SecondNumber}!");
