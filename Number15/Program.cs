// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число дня недели: ");
int number = int.Parse(Console.ReadLine());

int day(int num)
{
    if (num <= 7 && num >= 1)
    {
        return num > 5 ? 1 : 2;
    }
    else return -1;
}
int result = day(number);
string res;
if (result > 0)
{
  res = result == 1 ? "Выходные": "Будни";
  Console.Write($"{number} -> {res}");
}
else Console.Write("Нет такого дня недели");
