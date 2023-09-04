// Задача №5. Напишите программу, которая
//  на вход принимает одно число (N),
//   а на выходе показывает все целые
//    числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
Console.Write("Введите первое число ");
int number = int.Parse(Console.ReadLine()!);
int start = -number;
while(start < number)
{
    // Console.Write(start + " ");
    Console.Write(start + ", ");
    start++;
}
Console.Write(number);