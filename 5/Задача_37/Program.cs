// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.


int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int[] ResArray(int size)
{
    int sizeRes = size / 2 + size % 2;
    int[] res = new int[sizeRes];
    return res;
}

int[] Product(int[] array, int[] res, int size)
{
    for (int i = 0; i < size / 2; i++)
    {
        res[i] = array[i] * array[size -1 - i];
    }
    if(size % 2 != 0)
    {
        res[size / 2] = array[size / 2];
    }
    return res;
}


int size = InputNum("Введите размер массива: ");
int[] array = Array(size);
int[] resArray = ResArray(size);
int[] result = Product(array, resArray, size);

System.Console.WriteLine();
System.Console.WriteLine("[{0}]", string.Join(", ", array));
System.Console.WriteLine();

System.Console.WriteLine("[{0}]", string.Join(", ", result));
System.Console.WriteLine();