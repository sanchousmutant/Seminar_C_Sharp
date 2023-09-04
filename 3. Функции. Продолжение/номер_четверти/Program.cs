// Задача №17. Напишите программу, которая принимает
// на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер
//  четверти плоскости, в которой находится эта точка.


int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

string GetQuater(int axisX, int axisY)
{
    string answer = "";
    if (axisX > 0 && axisY > 0) answer = "Первая четверть";
    else if (axisX < 0 && axisY > 0) answer = "Вторая четверть";
    else if (axisX > 0 && axisY > 0) answer = "Третья четверть";
    else if (axisX > 0 && axisY < 0) answer = "Четвертая четверть";
    else answer = "Точка находится на границе четвертей";
    return answer;
}

int CoorX = InputNum("Введите координату x: ");
int CoorY = InputNum("Введите координату y: ");
string result = GetQuater(CoorX, CoorY);
System.Console.WriteLine(result);