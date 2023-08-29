// Определение кратности 7 и 23 введенного числа
// 161 % 7 == 0 и 161 % 23 == 0 -> Да
// 50 % 7 != 0 и 161 % 23 != 0 -> Нет 

bool Multiplicity(int number) // функция кратности
{
    return number % 7 == 0 && number % 23 == 0;
}
int InputNum(string message) // функция ввода
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int num = InputNum("Введите число: ");
bool result = Multiplicity(num);
 
string strResult = result ? "Да" : "Нет";  // if result (True or False) strResult = "Да" else strResult = "Нет"

System.Console.WriteLine(strResult);

