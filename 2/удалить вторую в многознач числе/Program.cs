// Напишите программу, которая выводит
// случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


int RemoveSecond(int num)
{
    int firstDigit = num / 100; // первое число, т.е. число сотен
    int secondDigit = num % 10; // третье число, т.е число едениц
    int result = firstDigit * 10 + secondDigit;
    return result;
}
    int number = new Random().Next(100, 1000); // произвольное число в интервале [100, 1000)
    int res = RemoveSecond(number);
    Console.WriteLine($"Исходное число {number}");
    Console.WriteLine($"Полученное число {res}");