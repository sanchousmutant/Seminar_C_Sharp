// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом 
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

int[] Backward(int[] array, int size)
{
    int temp = 0;
    for (int i = 0; i < size / 2; i++)
    {
        temp = array[i];
        array[i] = array[size - 1 -i];
        array[size - 1 -i] = temp;
    }
    return array;
}

System.Console.WriteLine();
int size = InputNum("Введите размер массива: ");
int[] array = Array(size);
System.Console.WriteLine();
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine();
int[] result = Backward(array, size);
System.Console.WriteLine("[{0}]", string.Join(", ", result));
System.Console.WriteLine();
