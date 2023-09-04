// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1
// Fn = Fn–2 + Fn–1

int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


void Fibonacci(int number)
{
    number -= 2;
    int first = 0;
    int second = 1;
    System.Console.Write($"{first} ");
    System.Console.Write($"{second} ");
    while(number > 0)
    {
        int fib = second + first;
        first = second;
        second = fib;
        number -= 1;
        System.Console.Write($"{fib} ");
        
    }
}

int number = InputNum("Введите число: ");
Fibonacci(number);