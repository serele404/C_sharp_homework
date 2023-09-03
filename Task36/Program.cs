// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(-99, 99);
    }
}

int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
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
int summ = FindSum(newArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {summ}");