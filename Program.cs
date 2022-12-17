// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите чисол сторк массива: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чисол столбцов массива: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[x, y];

var element = new Random();
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        array[i, j] = element.Next(-1 * 10, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int j = 0; j < y; j++)
{
    double summ = 0;
    for (int i = 0; i < x; i++)
    {
        summ = summ + array[i, j];
    }
    double average = summ / x;
    Console.WriteLine($"Среднее арифметическое {j + 1}-го столбца = {Math.Round(average, 3)} ");
}
