Console.WriteLine("Введите трёхзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int SecondNumber(int number)
{
    int numberB = number / 10 % 10;
    return numberB;
}
int result = SecondNumber(numberA);
Console.WriteLine($"Вторая цифра числа = {result}");