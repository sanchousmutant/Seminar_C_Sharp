string[] week = {"понедельник", "вторник", "среда", "четврерг", "пятница", "суббота", "воскресенье"};

Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);
Console.Write(week[day - 1]);