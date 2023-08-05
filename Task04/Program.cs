int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if(arg2>result) result=arg2;
if(arg3>result) result=arg3;
return result;
}

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

//int max = Max(number1, number2, number3);

Console.Write("Максимальное число из трех: ");
Console.WriteLine(Max(number1, number2, number3));