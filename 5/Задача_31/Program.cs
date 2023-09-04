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


int[] Sum(int[] array)
{
    int[] sum = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 0)
        {
            sum[0] += array[i];
        }
        else sum[1] += array[i];
    }
    return sum;
}


void Print(int[] sum)
{
    System.Console.WriteLine($"Сумма положительных чисел массива равна: {sum[0]}");
    System.Console.WriteLine($"Сумма отрицательных чисел массива равна: {sum[1]}");
}


int[] array = Array();
int[] sum = Sum(array);
System.Console.WriteLine();
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine();
Print(sum);
System.Console.WriteLine();