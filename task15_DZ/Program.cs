// Задача №15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот нет выходным.
// 6 -> Да 
// 7 -> Да
// 1 -> Нет
int EntNumber()
{
    int entNumber = int.Parse(Console.ReadLine()!);
    return entNumber;
}

Console.Write("Введите число: ");
int enteredNumber = EntNumber();
if (enteredNumber <= 5)
{
    Console.Write("Нет");
}
else
{
    Console.Write("Да");
}