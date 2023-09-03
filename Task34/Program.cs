// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(100, 999);
    }
}

int FindNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        count ++;
    }
    return count;
}


void PrintArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        System.Console.Write(newArray[i] + " ");
    }
    System.Console.WriteLine();
}
int size = InputNum("Введите размер массива");
int[] newArray = new int [size];
FillArray(newArray);
PrintArray(newArray);
int countOfNumbers = FindNum(newArray);
Console.WriteLine($"Количество четных чисел в массиве равно {countOfNumbers}");