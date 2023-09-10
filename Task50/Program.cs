﻿// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition 
// и PrintCheckIfError.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности,
// с каждым новым элементом увеличивающимся на определенное число. Метод принимает 
// на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы,
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, 
// удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом 
// CreateIncreasingMatrix матрицу.

// Метод FindNumberByPosition принимает на вход сгенрированную матрицу и 
// числа x и y - позиции элемента в матрице. Если указанные координаты 
// находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. 
// Если координаты находятся в пределах границ, метод должен вернуть массив 
// с двумя значениями: значением числа в указанной позиции, а второй элемент 
// должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition 
// и числа x и y - позиции элемента в матрице. Метод должен проверить, был ли найден 
// элемент в матрице по указанным координатам (x и y), используя результаты из метода 
// FindNumberByPosition. Если такого элемента нет, вывести на экран "There is no such index". 
// Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
        {
            if (i == 0 && j == 0) array[i, j] = 1;
            else if (j == 0) array[i, j] = array[i - 1, m - 1] + k;
            else array[i, j] = array[i, j - 1] + k;
        }
    return array;
}

int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
{
    int[] array = new int[2];
    if (rowPosition < matrix.GetLength(0) && columnPosition < matrix.GetLength(1))
        array[0] = matrix[rowPosition-1, columnPosition-1];
    else array[0] = 0;
    return array;
}

void PrintCheckIfError(int[] results, int X, int Y)
{
    if (results[0] == 0) Console.Write("There is no such index");
    else Console.Write($"The number in [{X}, {Y}] is {results[0]}");
}

// static public void Main(string[] args) {
//     int n, m, k, x, y;

//     if (args.Length >= 5) {
//        n = int.Parse(args[0]);
//        m = int.Parse(args[1]);
//        k = int.Parse(args[2]);
//        x = int.Parse(args[3]);
//        y = int.Parse(args[4]);
//     } else {
//        // Здесь вы можете поменять значения для отправки кода на Выполнение
//        n = 3;
//        m = 4;
//        k = 2;
//        x = 2;
//        y = 3;

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int koeff = InputNum("Введите число к: ");
int x = InputNum("Введите число x: ");
int y = InputNum("Введите число y: ");

int[,] result = CreateIncreasingMatrix(rows, columns, koeff);
PrintArray(result);
PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);