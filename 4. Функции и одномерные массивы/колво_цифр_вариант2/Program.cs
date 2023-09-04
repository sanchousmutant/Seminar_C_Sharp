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
  int count = (int)Math.Log10(num) + 1;

    return count;
}



int number = InputNum("Введите число: ");
int result = NumberOfDigits(number);
System.Console.WriteLine(result);