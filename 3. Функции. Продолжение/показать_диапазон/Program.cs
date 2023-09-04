// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).


int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void Range(int quarter)
{
    if(quarter == 1) System.Console.WriteLine("X > 0, Y > 0");
    else if(quarter == 2) System.Console.WriteLine("X < 0, Y > 0");
    else if(quarter == 3) System.Console.WriteLine("X < 0, Y < 0");
    else if(quarter == 4) System.Console.WriteLine("X > 0, Y < 0");
    else (System.Console.WriteLine("Такой четверти не существует");)
}

int qrt = InputNum("Введите номер четверти: ");
Range(qrt);