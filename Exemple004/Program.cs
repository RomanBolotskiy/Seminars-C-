Console.WriteLine ("Введите число 1");
int a1 = int.Parse (Console.ReadLine());

Console.WriteLine ("Введите число 2");
int a2 = int.Parse (Console.ReadLine());

int sqrt1 = a1*a1;
int sqrt2 = a2*a2;

if ((sqrt1 == a2) || (sqrt2 == a1))
{
    Console.WriteLine ("Да");
}

else
{
    Console.WriteLine ("нет");
}