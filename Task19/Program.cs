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

 bool IsPalindrome(int number)
{
    if (number > 9999 && number < 100000)
        {
            int firstDigit = number / 10000;
            int fiveDigit = number % 10;
            int secondDigit = number % 10000 / 1000;
            int fourDigit = number % 100 / 10;
            //System.Console.WriteLine($"Первое число:{firstDigit}, второе число:{secondDigit}");
            //System.Console.WriteLine($"Четвертое число:{fourDigit}, пятое число:{fiveDigit}");
            return firstDigit == fiveDigit && secondDigit ==fourDigit;
        } 
    else
    System.Console.WriteLine("Число не пятизначное");
    return number > 9999 && number < 100000;
}
int num = InputNum("Введите пятизначное число: ");
bool result = IsPalindrome(num);
 System.Console.WriteLine($"{result}");