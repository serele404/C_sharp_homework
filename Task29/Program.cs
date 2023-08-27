// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void ArrayOfNumbers()
{
    int[] randomArray = new int[8];
    System.Console.Write("[");
    for (int i = 0; i < 8; i++)
        {
        randomArray[i] = new Random().Next(1,99);
        System.Console.Write(randomArray[i] + ", ");
        }
    System.Console.Write("]");
}
ArrayOfNumbers();