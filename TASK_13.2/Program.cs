﻿/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("В вашем числе нет третьей цифы");
}
else
{
    do
    {
        number = number / 10;
        if (number < 1000)
        {
            number = number % 10;
            Console.WriteLine($"Третья цифра вашего числа : {number}");
        }
    }
    while (number > 100);
}