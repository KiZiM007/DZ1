// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int Metod(int num)
{
    if (num > 99 || num < -99)
    {
        while (num > 999 || num < -999)
        {
            num = num / 10;
        }
        return num % 10;
    }
    else return -1;
}
int result = Metod(number);
if (result == -1) Console.Write($"В числе {number} нет третьей цифры");
else Console.Write($"{result}");