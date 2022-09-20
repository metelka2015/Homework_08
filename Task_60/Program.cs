// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] ArrayTwoNumbers(int length, int first, int last)
{
    var random = new Random();
    int temp = 0;
    int[] source = new int[length];
    for (int i = 0; i < source.Length; i++)
    {
        source[i] = random.Next(first, last);
        temp = source[i];
        for (int j = 0; j < source.Length; j++)
        {
            while (temp == source[j])
            {
                temp = random.Next(10, 100);
                j = 0;
            }
        }
        source[i] = temp;
    }
    return source;
}
int[,,] ArrayWithRandomNumbers(int [] source,int m, int n, int t)
{
    int [,,] result = new int [m,n,t];
    int a = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = source[a];
                a++;
            }
        }
    }
    return result;
}
void PrintArray(int[,,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++) Console.Write($"{array[i, j, k]} ({i} {j} {k}) ");
            Console.WriteLine();
        }
    }
}

PrintArray (ArrayWithRandomNumbers(ArrayTwoNumbers(90,10,100), 3, 3, 3));
