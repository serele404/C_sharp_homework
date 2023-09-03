// Задача 43: Напишите программу, которая найдёт 
//точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
void Coordinates (int k1, int k2, int b1, int b2)
{
    if (k1 == k2 && b1 == b2) Console.Write("Прямые cовпадают и не пересекаются");
    else
    if (k1 == k2) Console.Write("Прямые параллельны и не пересекаются");
    else
    {
        double x = (b2 - b2) / (k1 - k2);
        double y = k1 * x + b1;
        // x = Math.Round(x, 3); 
        // y = Math.Round(y, 3);
        Console.WriteLine($"Прямые пересекаются в точке: ({x};{y})");
    }
}

int ratio1 = InputNum("Введите значение k1: ");
int ratio2 = InputNum("Введите значение k2: ");
int displacement1 = InputNum("Введите значение b1: ");
int displacement2 = InputNum("Введите значение b2: ");
Coordinates (ratio1, ratio2, displacement1, displacement2);
