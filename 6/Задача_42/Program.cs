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
        
        bin = $"{digit}" + bin;
    }
    
    System.Console.WriteLine(bin);
}

int number = InputNum("Введите число: ");
Binary(number);