// Задача №13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> Третьей цифры нет.
// 32679 -> 6

int EntNumber()
{
    int entNumber = int.Parse(Console.ReadLine()!);
    return entNumber;
}

Console.WriteLine("Введите число: ");
int enteredNumber = EntNumber();

if (enteredNumber < 100)
{
    Console.WriteLine("Третей цифры нет!");
}
if (enteredNumber >= 100 && enteredNumber <= 999)
{
    Console.WriteLine(enteredNumber % 10);
}
if (enteredNumber >= 1000 && enteredNumber <= 9999)
{
    Console.WriteLine((enteredNumber / 10) % 10);
}
if (enteredNumber >= 10000 && enteredNumber <= 99999)
{
    Console.WriteLine((enteredNumber / 100) % 10);
}

