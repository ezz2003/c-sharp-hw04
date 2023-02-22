// 24. Написать программу, которая принимает на вход число (А) и выдаёт сумму всех чисел от 1 до А.
// 
// 


int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

int SumConsecutiveNumbers(int num)
{
  int sum = 0;
  while (num > 0)
  {
    checked { sum += num; }   // Checked - для обработчика ошибок
    num--;
  }
  // for (int i = 1; i <= num; i++) sum += i;
  return sum;
}


Console.WriteLine(SumConsecutiveNumbers(InputInt("Введите натуральное число")));