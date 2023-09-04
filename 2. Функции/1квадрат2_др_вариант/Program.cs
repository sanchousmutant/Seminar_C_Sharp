// Задача №1. Напишите программу, которая 
// на вход принимает
// два числа и проверяет, является ли первое
// число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет


int InputNum(string message) // функция ввода
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool Square(int num1, int num2) // функция проверки равенства a == b ** 2
{
    if (num1 == num2 * num2)
    {
        return true;
    }
    else
    {
        return false;
    }
}
void PrintResult(bool res) // функция вывода проверки (True -> a == b ** 2 or False -> a != b ** 2) 
{
     if (res)
     {
        Console.WriteLine("Первое число является квадратом второго");
     }
     else
     {
        Console.WriteLine("Первое число не является квадратом второго");
     }
}

int numberFirst = InputNum("Введите первое число: ");
int numberSecond = InputNum("Введите второе число: ");

bool result = Square(numberFirst, numberSecond);
PrintResult(result);  // System.Console.WriteLine(result ? "Да" : "Нет"); тернарное условие
