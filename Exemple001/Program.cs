int num = new Random().Next (100, 1000);

int num1 = num % 10;
int num3 = num / 100;

int Result = num3 * 10 + num1;

Console.WriteLine($"Число{Result} из {num}");
