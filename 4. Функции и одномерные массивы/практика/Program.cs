int[] array1 = {1,2,3,4,5};
int[] array2 = array1;
System.Console.WriteLine(string.Join(" ", array1));
System.Console.WriteLine(string.Join(" ", array2));
System.Console.WriteLine("___________________________");
array1[2] = 10;
System.Console.WriteLine(string.Join(" ", array1));
System.Console.WriteLine(string.Join(" ", array2));
// массив ссылочный тип данных
System.Console.WriteLine("___________________________");
array2[4] = 15;
System.Console.WriteLine(string.Join(" ", array1));
System.Console.WriteLine(string.Join(" ", array2));
System.Console.WriteLine("___________________________");
int[] array4 = {7,6,5,4,3,2};
int[] array3 = new int[array4.Length];
for (int i = 0; i < array4.Length; i++)
{
    array3[i] = array4[i];
}
for (int i = 0; i < array3.Length; i++)
    {
        System.Console.Write(array3[i] + " ");
    }
array4[3] = 18;
System.Console.WriteLine();
System.Console.WriteLine(string.Join(" ", array4));