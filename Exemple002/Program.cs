Console.WriteLine ("Введите 2 числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 ==0)
{
    Console.WriteLine("Число 2 кратно числу 1");
}
else
{
    Console.WriteLine($"Число 1 не кратно числу 2, остаток от деления равен {num1 % num2}");
}