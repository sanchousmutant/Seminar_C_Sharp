// Задача №3. Напишите программу, которая будет
//  выдавать название дня недели по заданному
//   номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);

if( day == 1)
{
Console.Write("понедельник");
}
else if( day == 2)
{
Console.Write("вторник");
}
else if( day == 3)
{
Console.Write("среда");
}
else if( day == 4)
{
Console.Write("четверг");
}
else if( day == 5)
{
Console.Write("пятница");
}
else if( day == 6)
{
Console.Write("суббота");
}
else if( day == 7)
{
Console.Write("воскресенье");
}
else
{
    Console.Write("Такого дня недели нет");
}