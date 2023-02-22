// 26. Напишите программу, которая принимает на вход число, и выдаёт количество цифр в числе

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

int CountingNumbers(int num)
{
  int count = 1;
  while (true)
  {
    num = num / 10;
    if (num == 0) return count;
    count++;
  }
}

Console.WriteLine($"В введённом числе {CountingNumbers(InputInt("Введите число"))} цифр");