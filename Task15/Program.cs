﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine($"Введите порядковый номер дня недели и узнаете является ли он выходным: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(a == 6 | a == 7 ? "Выходной" : (a > 0 && a < 6 ? "Будний день" : "Выполнен неверный ввод!"));