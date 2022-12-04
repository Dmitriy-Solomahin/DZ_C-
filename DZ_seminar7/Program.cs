Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);

Console.WriteLine("Введите номер строки массива: ");
int i = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите номер столбца массива: ");
int j = int.Parse(Console.ReadLine()!);

PresenceElement(array,i,j);
Console.WriteLine("====================");
GetAvgColumn(array);



// ------------------Методы-----------------------
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int m, int n, int minValue, int maxValue){
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return result;
}


// Метод печати двумерного масссива
void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]:f2} ");
        }
        Console.WriteLine();
    }
}



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 5; j = 2 -> такого числа в массиве нет
// i = 1; j = 1 -> 9

void PresenceElement (double [,] array ,int i,int j){
    if (i< array.GetLength(0)&& i>0
    && j<array.GetLength(1)&& j>0){
        Console.WriteLine($"элемент масива в {i} строке, {j} столбце равен: {array[i-1,j-1]}");
    }
    else Console.WriteLine("такого элемента нет");
}



///////Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void GetAvgColumn(double[,] array)
{
    Console.Write("[");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum = sum + array[i, j];
            }
            Console.Write($"  {(sum / array.GetLength(0)):f2}  ");
        }
    }
    Console.WriteLine("]");
}



















