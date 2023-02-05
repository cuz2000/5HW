// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



void PrintArray(int[] array)
{
    System.Console.Write($"[{String.Join(",", array)}]\n");
}


int[] GenerateArr(int n, int min, int max)
{
    int[] arrNum = new int[n];

    Random rnd = new Random();

    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
}






int[] array = GenerateArr(10, 100, 999);
PrintArray (array);



int count = 0;

for (int j = 0; j < array.Length; j++)
if (array[j] % 2 == 0)
count++;

Console.WriteLine($"Количество четных элементов в массиве: {count}");

