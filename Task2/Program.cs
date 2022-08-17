/*
int num1 = num % 10;
int num3 = num / 100;

int Result = num3 / 10 + num1;

Console.WriteLine($"Число{Result} из {num}");
*/

Console.WriteLine("Введите число");
int a = int.Parse (Console.ReadLine());

int Result = (a / 100) % 10;

if (a % 100 == 0)
{
    Console.WriteLine ("Нет третьей цифры");
}
else
{
    Console.WriteLine ($"Цифра {Result}");
}
