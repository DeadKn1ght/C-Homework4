// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

Console.WriteLine("Input number : ");
int number = int.Parse(Console.ReadLine());

int SummNumbers(int numb)
{
    int summnumb = 0;
    for (summnumb = 0;numb > 0; numb = numb / 10)
    {
        summnumb = summnumb + (numb % 10);
    }
    return summnumb;
}

int summdigit = SummNumbers(number);
Console.WriteLine($"Summ of all digits in number is : " + summdigit);
