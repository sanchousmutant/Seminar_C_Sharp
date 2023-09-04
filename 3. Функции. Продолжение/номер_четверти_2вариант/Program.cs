int[] GetCoor (string message)
{
    int[] coordinates = new int[2];
    Console.Write(message + "X: ");
    coordinates[0] = int.Parse(Console.ReadLine()!);
    Console.Write(message + "Y: ");
    coordinates[1] = int.Parse(Console.ReadLine()!);
    return coordinates;
}

int[] GetCoor (string message)
{
    int[] coordinates = new int[2];
    Console.Write(message + "X: ");
    coordinates[0] = int.Parse(Console.ReadLine()!);
    Console.Write(message + "Y: ");
    coordinates[1] = int.Parse(Console.ReadLine()!);
    return coordinates;
}

int[] coors = GetCoor("Введите значение координаты ");
GetQuater(coors);