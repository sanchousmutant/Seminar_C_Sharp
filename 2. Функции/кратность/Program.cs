// Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли
// второе число кратным первому. Если число 2 не кратно
// числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно



int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

bool Multiplicity(int num1, int num2) // функция проверки кратности 
{
    return num1 % num2 == 0;
}


void CheckResult(bool mult, int num1, int num2)// функция вывода проверки
{
    if (mult)//(mult == true)
    {
        System.Console.WriteLine("Первое число кратно второму");
    }
    else
    {
      System.Console.WriteLine($"Первое число не кратно второму. Остаток от деления {num1 % num2}");  
    }
}


int firstNum = InputNum("Введите первое число: ");
int secondNum = InputNum("Введите второе число: ");

bool result = Multiplicity(firstNum, secondNum);
CheckResult(result, firstNum, secondNum);