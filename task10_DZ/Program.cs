// Задача №10
// Напишите прогрумму, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int TripleNumber()
{
    int tripleNumber = int.Parse(Console.ReadLine()!);
    return tripleNumber;
}
Console.WriteLine("Введите трехзнаxное число: ");
int entTripleNumber = TripleNumber();

int GetSecondDigit(int entTripleNumber)
{

    int secondDigit = (entTripleNumber / 10) % 10;
    return secondDigit;
}
if (entTripleNumber < 100 || entTripleNumber > 999)
    Console.WriteLine("Число не трехзначное");
else
    Console.WriteLine(GetSecondDigit(entTripleNumber));
