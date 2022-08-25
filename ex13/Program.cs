
Console.Write("Введите заданное число: ");
int numberХ = Convert.ToInt32(Console.ReadLine());
string numberХText = Convert.ToString(numberХ);
{
    if (numberХText.Length > 2)
    
      {
         Console.WriteLine($"Третья цифра числа = {numberХText[2]}");
      }  

    else
    Console.WriteLine("Третьей цифры в заданном числе нет");
      
}

