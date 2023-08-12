// Задача 10: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1


int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine());
}

int SecDigit(int num)
{
    int secondDigit = num % 100 / 10;
    return secondDigit;
}

int enterednumber =  InputNum("Введите трехзначное число: ");

if (enterednumber / 100 == 0 || enterednumber / 100 >= 10)
    {
        Console.WriteLine("Это не трехзначное число, повторно введите трехзначное число");
    }
else
    {
      int lookseconddigit = SecDigit(enterednumber);
       Console.WriteLine ($"Вторая цифра в числе {enterednumber} равна  {lookseconddigit}"); 
    }
