// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine());
}

int ThirdDigit(int num)
{
    int digitCount = (int)Math.Log10(num) + 1;
    Console.WriteLine ($"Количество цифр {num} равно  {digitCount}"); 
    int thirdDigit = num % (int)Math. Pow(10,digitCount-2) / (int)Math. Pow(10,digitCount-3);
    return thirdDigit;
}

int enterednumber =  InputNum("Введите число для определения третьей цифры: ");

if (enterednumber / 100 == 0)
    {
        Console.WriteLine("Третья цифра отсутствует");
    }
else
    {
      int lookthirdigit = ThirdDigit(enterednumber);
       Console.WriteLine ($"Третья цифра в числе {enterednumber} равна  {lookthirdigit}"); 
    }
