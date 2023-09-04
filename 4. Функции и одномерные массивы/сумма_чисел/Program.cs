// Задача 24: Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int SumFrom1ToNum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int number = InputNum("Введите число: ");
int result = SumFrom1ToNum(number);
System.Console.WriteLine(result);