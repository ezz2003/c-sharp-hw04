// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]



int[] GenerateArray()
{
  int[] array = new int[] { 1, 2, 5, 7, 19, 6, 1, 33 };
  return array;
}

string StrForPrintArray(int[] arr)
{
  string strPrn = String.Empty;
  for (int i = 0; i < arr.Length - 1; i++) strPrn += $"{arr[i]}, ";
  return strPrn += $"{arr.Last()}";
}

Console.WriteLine($"[{StrForPrintArray(GenerateArray())}]");
