// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


int MaxDigit(int num) // функция определения максимального числа в двузначном
{
    int secondDigit = num % 10; // 54 : 10 = 5,4 -> 5 4/10 -> 4 остаток от деления
    int firstDigit = num / 10; // 54 / 10 = 5 целочисленное деление
    int max = secondDigit;

    if (firstDigit > secondDigit)
        max = firstDigit;

    return max;
}

int number = new Random().Next(10, 100); // произвольное число в интервале [10, 100)
int result = MaxDigit(number);
Console.WriteLine($"В числе {number} максималььная цифра {result}");