using System;
// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 45);
    }
    return array;
}

int PositionArray(int[] array)
{
    int sum = 0;
    int position = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (position % 2 == 0) // == 0 - нечетная позиция по выведенным на экран числам. == 1 - нечетная позиция по индексу(от 0).
        {
            sum = sum + array[position];
        }
        position += 1;
    }
    return sum;
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
}




int[] array = CreateArray(4);
PrintArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {PositionArray(array)}");
