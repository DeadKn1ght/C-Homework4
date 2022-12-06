// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

Console.WriteLine("Input number A : ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Input number B : ");
int numberB = int.Parse(Console.ReadLine());

int Degree(int numberA, int numberB)
{
    int scale = 1;
    for (int i = 1; i <= numberB; i++)
    {
        scale *= numberA * ((i + 1) - i);
    }
    return scale;
}
int result = Degree(numberA, numberB);
Console.WriteLine("Degree number B of number A is :");
Console.WriteLine(result);