// // задача №2

Console.Write("введите число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
if (A > B) Console.Write($"max = {A}");
if (B > A) Console.Write($"max = {B}");

// // задача № 4

Console.Write("введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("введите третие число: ");
int c = int.Parse(Console.ReadLine()!);
int max = 0;
if (a > b) max = a;
else max = b;
if (max < c) max = c;
Console.Write($"max = {max}");

// // задача 6

Console.Write("введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n%2 == 0) Console.Write($"число {n} четное");
else Console.Write($"число {n} не четное");

// задача 8

Console.Write("введите число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
while(i <= N)
{
    if(i%2 == 0) Console.Write($"{i} ");
    i++;
}
