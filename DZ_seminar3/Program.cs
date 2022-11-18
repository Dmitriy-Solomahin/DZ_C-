// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// (первое число равно последнему, второе равно предпоследнему).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("введите пятизначное число: ");
string namber = Console.ReadLine()!;
if (namber.Length !=5) Console.WriteLine("введите пятизначное число! ");
else {
    if (namber[0] == namber[4] && namber[1] == namber[3]) Console.WriteLine("палиндром");
    else Console.WriteLine("не палиндром");
}


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("введите координаты 1й точки по оси х: ");
double ax = double.Parse(Console.ReadLine()!);
Console.Write("введите координаты 1й точки по оси y: ");
double ay = double.Parse(Console.ReadLine()!);
Console.Write("введите координаты 1й точки по оси z: ");
double az = double.Parse(Console.ReadLine()!);
Console.Write("введите координаты 2oй точки по оси х: ");
double bx = double.Parse(Console.ReadLine()!);
Console.Write("введите координаты 2oй точки по оси y: ");
double by = double.Parse(Console.ReadLine()!);
Console.Write("введите координаты 2oй точки по оси z: ");
double bz = double.Parse(Console.ReadLine()!);

Console.WriteLine($"растояние между первой и второй точкой = {Math.Sqrt(Math.Pow(ax-bx,2)+Math.Pow(ay-by,2)+Math.Pow(az-bz,2)):f2}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("введите чило N: ");
int N = int.Parse(Console.ReadLine()!);
for (int i = 1; i<=N ; i++) Console.Write($"{Math.Pow(i,3)} ");

