// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


string InputArrayElements (string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

int[] CreateFillArray (string seriesOfNumbers)
{   
    char[] delimiterChars = {' ', ',', '.'};
    string[] arr = seriesOfNumbers.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
    int[] arr1 = Array.ConvertAll(arr, int.Parse);

    return arr1;
}

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//        Console.Write(arr[i] + " ");
//     Console.WriteLine();
// }

int NumberCounter(int[] arr)
{
    int numbers = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) 
            numbers++;
    }
    return numbers;
}

string series = InputArrayElements("Введите числа в одну строку: ");
int[] array = CreateFillArray (series);
// PrintArray(array);
int num = NumberCounter (array);
Console.WriteLine($"Количество чисел больше нуля среди тех, которые вы ввели равно {num}");


