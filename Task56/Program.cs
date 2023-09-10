// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(minValue, maxValue + 1);
}

int[] Array1D(int[,] array)

{
    int[] Array1D = new int[array.GetLength(0)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Array1D[index] += array[i, j];
        }
        index++;
    }
    return Array1D;
}

int FindMin(int[] array)
{   
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
            min = array[i];
            }
        }
    return min;
}
void FindMinPosition(int[] array, int min)
{   
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == min)
            Console.WriteLine($"Номер строки c наименьшей суммой элементов: {i + 1} строка");
        }
}


void Print1DArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");  
    }
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = Create2DArray(rows, columns);

int min = InputNum("Введите минимальное значение элемента: ");
int max = InputNum("Введите максимальное значение элемента: ");

Fill2DArray(myArray, min, max);
Print2DArray(myArray);
Console.WriteLine();
int[] listArray =  Array1D(myArray);
Print1DArray(listArray);
Console.WriteLine();
int minimum = FindMin(listArray);
FindMinPosition(listArray, minimum);