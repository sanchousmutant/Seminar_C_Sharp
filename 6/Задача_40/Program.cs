// Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.



void Triangle(int sideA, int sideB, int sideC)
{
    if(sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideB + sideA)
        System.Console.WriteLine("YES");
    else System.Console.WriteLine("NO");    
}

int sideA = new Random().Next(1,10);
int sideB = new Random().Next(1,10);
int sideC = new Random().Next(1,10);
System.Console.WriteLine($"{sideA}  {sideB}  {sideC}");
Triangle(sideA, sideB, sideC);