// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] CreateArray(int value)
{
    int[] array = new int[value];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
}


int AmountNum(int[] amount)
{
    int count = 0;
    for (int i = 0; i < amount.Length; i++)
    {
        if (amount[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}


int[] array = CreateArray(4);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве: {AmountNum(array)}");
