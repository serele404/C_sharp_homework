// //  Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int Еxponentiation(int number, int degree)
{
    int composition = 1;
    for (int i = 1; i <= degree; i++, composition *= number);
    return composition;
}

int num= InputNum("Введите число A: ");
int deg= InputNum("Введите число B: ");
int comp = Еxponentiation(num, deg);
Console.WriteLine($"Число {num} в сетепни {deg} равно {comp}");
