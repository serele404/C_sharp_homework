// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и 
// FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
// с каждым новым элементом увеличивающимся на опрделенное число. Метод принимает 
// на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, 
// k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, 
// удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает 
// одномерный массив типа double. Этот метод вычисляет среднее значение чисел в каждом 
// столбце матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns 
// и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...",
//  где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой, 
//  разделенные знаком табуляции.

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

double [] FindAverageInColumns (int [,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    int index = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[index] = array[index] + matrix[i, j];
        }
        array[index] = array[index] / matrix.GetLength(0);
        index++;
    }
    return array;
}
void PrintListAvr (double [] list)
{   
    Console.WriteLine("The averages in columns are: ");
    for (int i = 0; i < list.Length; i++)
        Console.Write($"{list[i]:f2}\t");
}


// static public void Main(string[] args) {
//         int n, m, k;

//         if (args.Length >= 3) {
//            n = int.Parse(args[0]);
//            m = int.Parse(args[1]);
//            k = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            n = 3;
//            m = 4;
//            k = 2;
//         }

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int koeff = InputNum("Введите число к: ");

int[,] result = CreateIncreasingMatrix(rows, columns, koeff);
PrintArray(result);
PrintListAvr(FindAverageInColumns(result));