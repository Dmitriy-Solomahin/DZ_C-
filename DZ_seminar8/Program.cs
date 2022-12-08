
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = GetArray(4, 5);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);


void SortArray(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            int min = array[k, i];
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k, j] > array[k, i])
                {
                    int hub = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = hub;
                }
            }
        }
    }
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine();
Console.WriteLine($"{MinSumElementsntArray(array) + 1} строка содержит минимальную сумму элементов");


int MinSumElementsntArray(int[,] array)
{
    int sum = 0, n = 0;
    int[] Nsum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Nsum[i] = sum;
        sum = 0;
    }
    sum = Nsum[0];
    for (int k = 0; k < Nsum.Length; k++)
    {
        if (Nsum[k] < sum)
        {
            sum = Nsum[k];
            n = k;
        }
    }
    return n;
}



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine();
int[,] array1 = GetArray(2, 2);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(2, 2);
PrintArray(array2);
Console.WriteLine();
array = ProductTwoMatrices(array1, array2);
PrintArray(array);




int[,] ProductTwoMatrices(int[,] arrayA, int[,] arrayB)
{
    int[,] result = new int[arrayA.GetLength(0), arrayA.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int x = 0; x < result.GetLength(0); x++)
            {
                sum += arrayA[i, x] * arrayB[x, j];
            }
            result[i, j] = sum;
            sum = 0;
        }
    }
    return result;
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine();
int [,,] bigArray = GetTridimensionalArray(2,2,2);
PrintBigArray(bigArray);




int[,,] GetTridimensionalArray(int x, int y, int z )
{
    int[,,] result = new int[x,y,z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++){
                while (true){
                    bool indikator =true;
                    int number = new Random().Next(10, 100);
                    foreach(int n in result){
                        if (n == number) indikator = false;
                    }
                    
                    if (indikator == true){
                        result[i,j,k] = number;
                        break;
                    }
                }
            }
            
        }
    }
    return result;
}

void PrintBigArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
        Console.WriteLine();
        }
    }
}


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.WriteLine();
int[,] arrayS = GetSpiralArray(4, 4);
PrintArray(arrayS);


int[,] GetSpiralArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int number = 1, minIndexRow = 0, maxIndexRow = row-1,
            minIndexColumn = 0, maxIndexColumn = column-1; 
            number <= result.GetLength(0)*result.GetLength(1); )
    {
        for(int i = minIndexRow, j = minIndexColumn; j <= maxIndexColumn; j++){
            result[i,j] = number;                                               // заполнение верхнего края
            number++;
        }
        minIndexRow ++;                                                         // уберал верхнюю линию из дальнейших расчетов
        if (number > result.GetLength(0)*result.GetLength(1)) break;
        
        for(int i = minIndexRow, j = maxIndexColumn; i <= maxIndexRow; i++){
            result[i,j] = number;                                               // заполнение правого края
            number++;
        }
        maxIndexColumn --;                                                      // убрал правый столбец из дальнейших расчетов
        if (number > result.GetLength(0)*result.GetLength(1)) break;
        
        for(int i = maxIndexRow, j = maxIndexColumn; j >= minIndexColumn; j--){
            result[i,j] = number;                                               // заполнение нижнего края
            number++;
        }
        maxIndexRow --;                                                         // убрал нижней строки из дальнейших расчетов
        if (number > result.GetLength(0)*result.GetLength(1)) break;
        
        for(int i = maxIndexRow, j = minIndexColumn; i >= minIndexRow; i--){
            result[i,j] = number;                                               // // заполнение левого края
            number++;
        }
        minIndexColumn ++;                                                      // убрал левого столбец из дальнейших расчетов
    }
    return result;
}






