// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// while (num > 0)
// {
//     sum = sum + num % 10;
//     num = num / 10;
// }
// Console.WriteLine($"Сумма цифр числа = {sum}");



int SumDigit(int number)
{
    if (number < 10) return number;
    int sum = number % 10;
    int sum1 = number / 10;

    return sum + SumDigit(sum1);
}

int result = SumDigit(num);
Console.WriteLine($"Сумма цифр числа {num} ==> {result}");
