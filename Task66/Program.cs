// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SummNumbers(int M, int N)
{
    if (N < M) return 0;
    else if (M == N) return N;
    else return N + SummNumbers(M, --N);
}

int first = InputNum("Введите число M:");
int second = InputNum("Введите число N:");
int summ = SummNumbers(first, second);
Console.WriteLine(summ);