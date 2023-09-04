// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива

int[] Array()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}


void Sum(int[] array)
{
    int[] sum = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            sum[0] += array[i];
        }
        else sum[1] += array[i];
    }
    System.Console.WriteLine("Сумма положительных"
    + $" чисел массива равна: {sum[0]}");
    System.Console.WriteLine("Сумма отрицательных"
    + $" чисел массива равна: {sum[1]}");
}


int[] array = Array();
System.Console.WriteLine();
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine();
Sum(array);
System.Console.WriteLine();