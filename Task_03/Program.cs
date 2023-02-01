// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(int len)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 99);

    }
    return array;
}

double DifferenceMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];

    }
    return max;

}

double DifferenceMin(double[] array)
{

    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];

    }
    return min;

}

void PrintArray(double[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
}

double[] array = CreateArray(4);
PrintArray(array);
Console.WriteLine($"Максимальный элемент: {DifferenceMax(array)}");
Console.WriteLine($"Минимальный элемент: {DifferenceMin(array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {DifferenceMax(array) - DifferenceMin(array)}");
