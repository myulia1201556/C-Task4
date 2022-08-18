// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2.выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Clear();

int[] arr = { 1, 2, 5, 7, 19, 6, 1, 33 };

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[ ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");

    Console.WriteLine();
}
PrintArray(arr);
