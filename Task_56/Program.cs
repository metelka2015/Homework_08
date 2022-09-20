// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = random.Next(1, 10);
    return result;
}
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
void LowerSum (int [,] array)
{
    int [] SumIndex = new int [array.GetLength(0)];
    int currentSum= 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {  
        currentSum=0;
        for (int j = 0; j < array.GetLength(1); j++) currentSum += array [i,j];
        Console.WriteLine ($"Сумма в строке {i} ={currentSum}");
        SumIndex[i]= currentSum;                        
    }
    int lower = SumIndex [0];
    int result = 0;
    for (int k = 0; k < SumIndex.Length; k++)
    {
        if (SumIndex [k] < lower) 
        {
            lower = SumIndex [k];
            result = k;
        }
    }           
    Console.WriteLine ($"Наименьшая сумма элементов в строке:{result}");
}

int [,] array = CreateArrayWithRandomNumbers (4,4);
Console.WriteLine ();
PrintArray (array);
LowerSum (array);