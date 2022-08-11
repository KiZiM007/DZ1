// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
void Metod(int num)
{
    if (num <= 999 && num >= 100)
    {
        int num1 = num / 100;
        int num2 = num - num1 * 100;
        int num3 = num2 / 10;
        Console.Write($"{num3}");
    }
    else Console.Write("Вы ввели не трехзначное число");
}
Metod(number);
