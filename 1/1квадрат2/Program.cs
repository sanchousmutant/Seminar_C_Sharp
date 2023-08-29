// Задача №1. Напишите программу, которая 
// на вход принимает
// два числа и проверяет, является ли первое
// число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
if(num1 == num2 * num2)
{
   Console.WriteLine($"Число {num1} является квадратом {num2}"); 
}
else
{
       Console.WriteLine($"Число {num1} не является квадратом {num2}"); 
 
}
