﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[4];

for (int i = 0; i< array.Length; i++)
{
    System.Console.Write($"array[{i}]: ");
    array[i] = Convert.ToString(Console.ReadLine());
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"array[{i}]: {array[i]} ");
    }
}
PrintArray(array);