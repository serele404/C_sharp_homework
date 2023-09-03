// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateFillArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(rand.Next(0,99)+rand.NextDouble(), 3);
    return array;
}


double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
    System.Console.Write($"Максимальное число в массиве: {max}");
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
    System.Console.Write($"Минимальное число в массиве: {min}");
}

void PrintArray(double[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        System.Console.Write(newArray[i] + " ");
    }
    System.Console.WriteLine();
}
int sizeArray = InputNum("Введите размер массива");
double[] newArray = CreateFillArray(sizeArray);
PrintArray(newArray);
double maximum = FindMax(newArray);
double minimum = FindMin(newArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {maximum - minimum}");
