// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int count = 0;
int EvenNumberPlus = 2;
int EvenNumberMinus = 0;

if (number < 0)
    {
        while (EvenNumberMinus >= number)
        {
            {
            Console.WriteLine(EvenNumberMinus);
            EvenNumberMinus = EvenNumberMinus - 2;
            }
        count++;
        }
    }
else 
    if (number == 0)
        {
            Console.WriteLine("Введите число, отличное от нуля");
        }
else
     if (number > 0)   
        while (EvenNumberPlus <= number)
        {
            {
            Console.WriteLine(EvenNumberPlus);
            EvenNumberPlus = EvenNumberPlus + 2;
            }
        count++;
        }

