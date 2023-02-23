// 30. Напишите программу, которая которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] GenerateArray()
{
  int arrLength = 8;
  int[] array = new int[arrLength];
  for (int i = 0; i < arrLength; i++) array[i] = new Random().Next(0, 2);
  return array;
}

void PrintArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
}

PrintArray(GenerateArray());


