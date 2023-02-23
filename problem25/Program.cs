// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 
// 3, 5 -> 243 (3⁵)
// 
// 2, 4-> 16

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

int CustomPow(int num, int degree)
{
  int res = 1;
  for (int i = 0; i < degree; i++) res *= num;
  return res;
}

int a = InputInt("Введите число - основание");
int b = InputInt("Введите степень числа");
Console.WriteLine($"{a}, {b} -> {(CustomPow(a, b))}");

