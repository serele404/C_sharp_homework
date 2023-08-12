// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine());
}

void CheckDayWeek(int day) 
{
  if (day == 6 || day == 7) 
  {
    Console.WriteLine(" -> да, это выходной");
  }
  else if (day < 1 || day > 7) 
  {
    Console.WriteLine("Такого дня недели нет, введите число от 1 до 7 ");
  }
  else 
    Console.WriteLine(" -> нет, это не выходной");
}

int day =  InputNum("Введите цифру, обозначающую день недели от 1 до 7: ");

CheckDayWeek(day);