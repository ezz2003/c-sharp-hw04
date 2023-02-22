// 24. Написать программу, которая принимает на вход число (N) и выдаёт произведение всех чисел от 1 до N.
// 
// 


int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

int GetFactorial(int num)
{
  int f = 1;
  while (num > 0)
  {
    checked { f *= num; }   // Checked - для обработчика ошибок
    num--;
  }
  // for (int i = 1; i <= num; i++) f *= i;
  return f;
}


Console.WriteLine($"Факториал введённого числа = {GetFactorial(InputInt("Введите натуральное число"))}");