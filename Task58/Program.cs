// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minValue, maxValue + 1);
}

int[,] MultiplicationArray(int[,] array1, int[,] array2, int[,] multiArray)
{
  for (int i = 0; i < array1.GetLength(0); i++)
  {
    for (int j = 0; j < array2.GetLength(1); j++)
    {
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        multiArray[i,j] += array1[i,k] * array2[k,j];
      }
    }
  }
  return multiArray;
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

bool IsValidDataMatrix(int rowsCount, int colsCount)
{
  return rowsCount == colsCount;
}

int rows1 = InputNum("Введите количество строк первой матрицы: ");
int columns1 = InputNum("Введите количество столбцов второй матрицы: ");
int rows2 = InputNum("Введите количество строк второй матрицы: ");
int columns2 = InputNum("Введите количество столбцов второй матрицы: ");
int min = InputNum("Введите значение минимального элемента: ");
int max = InputNum("Введите значение максимального элемента: ");

// Умножать матрицы можно тогда и только тогда, когда количество столбцов 
// первой матрицы равно количеству строк второй матрицы.

if (IsValidDataMatrix(rows2, columns2))
{
  int[,] myArray1 = Create2DArray(rows1, columns1);
  int[,] myArray2 = Create2DArray(rows2, columns2);

  Fill2DArray(myArray1, min, max);
  Fill2DArray(myArray2, min, max);
  Console.WriteLine("Первая матрица:");
  Print2DArray(myArray1);
  Console.WriteLine("Вторая матрица:");
  Print2DArray(myArray2);

  int[,] resultArray = Create2DArray(rows1, columns2);

  int[,] multiArray = MultiplicationArray(myArray1, myArray2, resultArray);
  Console.WriteLine("Результат умножения первой матрицы на вторую:");
  Print2DArray(multiArray);
}
else
{
  Console.Write("Не возможно умножить матрицы");
}