﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// Например:
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.Write("Введите натуральное число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int number)
{
    if (number < 0) Console.Write($"{number} не натульное");
    
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NaturalNumber(number - 1);
}

NaturalNumber(number);