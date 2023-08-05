// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
void Even(int arg1)
{
int remainder = arg1 % 2;
if (remainder == 0) 
    { 
    Console.WriteLine("Это четное число");
    }
    else
    { 
    Console.WriteLine("Это нечетное число");
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Even(number);