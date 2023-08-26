// Напишите программу, которая принимает на вход число (N) и
//выдаёт таблицу кубов чисел 
// от 1 до N.

// N = 3 
// 1
// 8
// 27

// N = 5
// 1
// 8
// 27
// 64
// 125


int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void ShowCube(int N)
{
    for (int i = 1; i <=N; i++)
    {
        int res = (int)Math.Pow(i,3);
        System.Console.WriteLine(res);
        System.Console.Write("");
    }
}
int number = InputNum("Введите число: ");
ShowCube(number);