// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray(int m, int n)
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
int[,] ResultArray(int[,] firstArray, int[,] secondArray)
{
    int[,] result = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
    for (int i=0; i<firstArray.GetLength (0); i++)
        {
            for (int j=0; j<secondArray.GetLength (1); j++) 
            {
                for (int k=0; k<secondArray.GetLength (1); k++)
                result [i,j] += firstArray [i,k]*secondArray [k,j]; 
            }      
        }
    
    return result;
}
Console.WriteLine("Первый массив");
int[,] firstArray = CreateArray(2, 2);
PrintArray(firstArray);
Console.WriteLine("Второй массив");
int[,] secondArray = CreateArray(2, 2);
PrintArray(secondArray);
Console.WriteLine("Резльтирующий массив");
PrintArray(ResultArray(firstArray, secondArray));