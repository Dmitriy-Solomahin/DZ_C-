// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(n,1));

string PrintNumbers(int start, int end){
    if (start==end) return start.ToString();
    return(start + " " + PrintNumbers(start - 1, end));
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumber(M,N));

int PrintNumber(int M, int N){
    if (M==N) return M;
    return(M += PrintNumber(M + 1, N));
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("введите число M: ");
int Mm = int.Parse(Console.ReadLine()!);

Console.Write("введите число N: ");
int Nn = int.Parse(Console.ReadLine()!);

Console.WriteLine(AckermanFunction(Mm,Nn));

int AckermanFunction(int m, int n){
    if ( m == 0) return  n+1;
    if ( m>0 && n==0) return AckermanFunction(m-1,1);
    return AckermanFunction(m-1,AckermanFunction(m,n-1)); //if ( m>0 && n>0) 
}