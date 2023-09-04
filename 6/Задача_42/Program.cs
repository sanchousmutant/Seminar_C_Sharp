// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


void Binary(int number)
{
    string bin = string.Empty;
    while(number > 0)
    {
        int digit = number % 2;
        number /= 2;
        
        bin += $"{digit}";
    }
    for (int i = 0; i < bin.Length; i++)
    {
        System.Console.Write($"{bin[bin.Length - 1 - i]}");
    }
}

int number = InputNum("Введите число: ");
Binary(number);