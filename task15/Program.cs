﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

    if (dayNumber == 6 || dayNumber == 7) 
{
  Console.WriteLine("День выходной");
}
    else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("это не является днем недели");
}
    else Console.WriteLine("День не выходной");


