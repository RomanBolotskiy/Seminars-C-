Console.WriteLine ("Введите число от 1 до 7");
int dayNumber = int.Parse (Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine ("Это выходной день");
    }
    else
    {
        Console.WriteLine ("Это не выходной день");
    }
}
CheckingTheDayOfTheWeek (dayNumber);

