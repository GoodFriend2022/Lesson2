﻿// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int outSecondNumber = number / 100 * 10 + number % 10;
System.Console.WriteLine($"Число {number} без второй цифры выглядит следующим образом > {outSecondNumber}");


