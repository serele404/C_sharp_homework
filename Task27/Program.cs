// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int NumberofDigits(int num)
{
    int i;
    for (i = 0; num != 0; i++)
    {
        num /= 10;
    }
    return i;
}
int Sum(int num1, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += num1 % 10;
num1 /= 10;
}
return sum;
}

int number = InputNum("Введите число: ");
int digits = NumberofDigits(number);
int summ = Sum(number, digits);
Console.WriteLine($"Сумма цифр в числе {number} равна {summ}");