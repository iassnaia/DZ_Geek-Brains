Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = numberA / 100 % 10;
{
    if (numberA < 100)
        Console.WriteLine("Третьей цифры в заданном нет");

    else

        Console.WriteLine($"Третья цифра числа = {numberB}");
}
