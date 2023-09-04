// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]

int[] Array()
{
    Random rnd = new Random();
    int[] array = new int[123];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(123);
    }
    return array;
}

void Search(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99)
        {
            result += 1;
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine(result);
    System.Console.WriteLine();
}

int[] array = Array();
System.Console.WriteLine();
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine();
Search(array);