// Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования

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

void CopyArray(int[] array, int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = array[i];
    }
    System.Console.WriteLine("[{0}]", string.Join(", ", res));
}

System.Console.WriteLine();
int size = InputNum("Введите размер массива: ");
int[] array = Array(size);
System.Console.WriteLine();
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine();
CopyArray(array, size);