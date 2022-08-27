Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void PalindromeRow(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  Console.WriteLine($"Число {number} - палиндром.");
  
  else 
  Console.WriteLine($"Число {number} - не палиндром.");
}
{
if (number!.Length == 5)
   PalindromeRow(number);
else Console.WriteLine($"Число введено не верно");
}