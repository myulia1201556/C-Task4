// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

 int Pow(int a, int b)
 {
int result = a;
for (int i = 1; i < b; i++)
{
        result *= a;
}
if (b == 0) result = 1;
return result;
 }
int result = Pow(numA, numB);
Console.WriteLine($"Результат возведения числа {numA} в степень {numB} = {result}");
