// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2.выводит их на экран.


Console.Clear();
Console.WriteLine("Введите размер массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int len)
{
    int[] arrays = new int[len];
    for (int i = 0; i < arrays.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        arrays[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrays;
}
int[] result = CreateArray(lenght);

void PrintArray(int[] result1)
{
    Console.Write($"[ ");
    for (int i = 0; i < result1.Length; i++)
    {
        Console.Write($"{result1[i]} ");
    }
    Console.Write($"]");
}

PrintArray(result);




