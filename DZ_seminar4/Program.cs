/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// //метод
// int DegreesNamber1(int namber, int degrees)
// {
//     int result = namber;
//     for (int i = 1; i < degrees; i++) result *= namber;
//     return result;
// }
// // программа
// Console.Write("введите число: ");
// int a = Convert.ToInt32(Console.ReadLine()!);
// Console.Write($"введите число в какую степень нужно возвести число {a}: ");
// int b = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine($"Число {a} в сепени {b} равно: {DegreesNamber1(a, b)} ");

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// //метод
// int SumNumbers(int namber){
//     int result=0;
//     for( int i = 10 ; namber>0; namber/=i){
//         result+=namber%i;
//         Console.WriteLine(result);
//     }
//     return  result;
// }
// // программа
// Console.Write("введите число: ");
// int A = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine($"Сумма цыфр числа {A}, равна: {SumNumbers(A)}");

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
*/

//метод
int[] FillArrey(int size){
    int[] arrey = new int[size];
    for(int i = 0;i<size;i++) arrey[i] = new Random().Next(10,50);
    return arrey;
}
// программа


int B = 8;
Console.WriteLine($"массив [{String.Join(" ",FillArrey(B))}]");