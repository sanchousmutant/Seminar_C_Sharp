// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreatedArray(int size)
{
    return new int[size];
}
void FillArray(int[] ints)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = rnd.Next(2);
    }
}
string PrintArray(int[] ints)
{
    string res = "";
    for (int i = 0; i < ints.Length; i++)
    {
        res += $"{ints[i]} ";
    }
    return res;
}

int size = InputNum("Введите размер массива: ");
int[] myArray = CreatedArray(size);
FillArray(myArray);
string res = PrintArray(myArray);
System.Console.WriteLine(res);