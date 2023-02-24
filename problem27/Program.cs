// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 
// 452 -> 11
// 
// 82 -> 10
// 
// 9012 -> 12

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

int CountSumDigits(int num)
{
  int drive = 0;
  while (num != 0)
  {
    drive = drive + (num % 10);
    num /= 10;
  }
  return drive;
}

int number = InputInt("Введите число для подсчёта суммы цифр");
Console.WriteLine($"{number} -> {CountSumDigits(number)}");