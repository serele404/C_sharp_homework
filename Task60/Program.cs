// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int rows, int columns, int lists)
{
  return new int[rows, columns, lists];
}

int[] GenerateArray1D(int maxValue, int minValue, int size)
{
  int[] array = new int[size];
  Random rnd = new Random();
  array[0] = rnd.Next(minValue, maxValue + 1);

  for (int i = 1; i < array.Length; i++)
  {
    array[i] = rnd.Next(minValue, maxValue + 1);
    for (int j = 0; j < i; j++)
    {
      while (array[i] == array[j])
        {
          array[i] = rnd.Next(minValue, maxValue + 1);
          j = 0;
        }
    }
  }
  return array;
}


void Fill3DArray(int[,,] array, int[] array1D)
{
  int count = 0;
  Random rnd = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = array1D[count];
        count++;
      }
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    System.Console.Write(array[i] + " ");
  }
}

void Print3DArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      {
        for (int k = 0; k < array.GetLength(2); k++)
        Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
        Console.WriteLine();
      }
  }
}

int SizeArray(int rows, int columns, int lists)
{
  return rows * columns * lists;
}

bool IsValidDataMatrix(int maxValue, int minValue, int sizeArray)
{
  return maxValue + 1 - minValue >= sizeArray;
}


int rows1 = InputNum("Введите количество строк трехмерной матрицы: ");
int columns1 = InputNum("Введите количество столбцов трехмерной матрицы: ");
int lists1 = InputNum("Введите количество листов трехмерной матрицы: ");
int min = InputNum("Введите значение минимального элемента: ");
int max = InputNum("Введите значение максимального элемента: ");
int amountArray = SizeArray(rows1, columns1, lists1);


if (IsValidDataMatrix(max, min, amountArray))
{
  int[,,] myArray = Create3DArray(rows1, columns1, lists1);
  int[] array1DSize = GenerateArray1D(max, min, amountArray);
  Console.WriteLine($"Одномерный массив неповторяющихся чисел размерностью {rows1}x{columns1}x{lists1}:");
  PrintArray(array1DSize);
  Console.WriteLine();
  Console.WriteLine("Элементы трехмерного массива:");
  Fill3DArray(myArray, array1DSize);
  Print3DArray(myArray);
}
else
{
  Console.Write("Диапазон неповторяющихся чисел меньше, чем размерность массива!");
}