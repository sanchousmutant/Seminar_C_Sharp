// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] ReplaceArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }

    System.Console.WriteLine("[{0}]", string.Join(", ", array));

    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}



int size = InputNum("Введите размер массива: ");
System.Console.WriteLine();
int[] array = ReplaceArray(size);
System.Console.WriteLine();
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine();