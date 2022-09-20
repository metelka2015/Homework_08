// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
int count = 1;
for (int i = 0; i < 4; i++)
{
    array[0, i] = count;
    count++;
}
for (int i = 1; i < 4; i++)
{
    array[i, 3] = count;
    count++;
}
for (int i = 2; i < 5; i++)
{
    array[3, 4 - i] = count;
    count++;
}
for (int i = 2; i < 4; i++)
{
    array[4 - i, 0] = count;
    count++;
}
for (int i = 1; i < 3; i++)
{
    array[1, i] = count;
    count++;
}
for (int i = 2; i < 4; i++)
{
    array[2, 4 - i] = count;
    count++;
}

PrintArray(array);