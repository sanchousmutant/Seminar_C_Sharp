// Задача 26: Напишите программу, которая 
// принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5




int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int NumberOfDigits(int num)
{
    int count = 0;
    while(num != 0)
    {
        num = num / 10;
        count += 1;
    }
    return count;
}

// int NumOfDigits(int num)
// {
//     int i;
//     for (i = 0; num != 0; i++) // for (i = 0; num != 0; i++, num /= 10);
//         num /= 10;
//     return i;
// }

int number = InputNum("Введите число: ");
int result = NumberOfDigits(number);
System.Console.WriteLine(result);