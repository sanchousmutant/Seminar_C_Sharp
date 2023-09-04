// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void Search(int[] array, int number)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        {
            result += 1;
        }
    }
    if(result > 0)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("да");
        System.Console.WriteLine();
    }
    else
    {
         System.Console.WriteLine();
        System.Console.WriteLine("нет");
        System.Console.WriteLine();
    }
}

int size = InputNum("Введите размер массива: ");
int[] array = Array(size);
int number = InputNum("Введите искомое число: ");
System.Console.WriteLine();
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine();
Search(array, number);