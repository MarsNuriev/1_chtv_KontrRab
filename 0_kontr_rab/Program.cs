// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[4];
void ReadArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"array[{i}]: ");
        arr[i] = Convert.ToString(Console.ReadLine()!);
    }
}
ReadArray(array);
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
System.Console.WriteLine("Массив стартовый:");
PrintArray(array);
System.Console.WriteLine();
void PrintArrayFilter3(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        { System.Console.Write($"{array[i]} "); }
    }
}
System.Console.WriteLine("Массив после обработки:");
PrintArrayFilter3(array);