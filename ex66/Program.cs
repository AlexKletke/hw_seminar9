//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("enter M > 0: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("enter N > M: ");
int N = int.Parse(Console.ReadLine());
int SumElementsMN (int M, int N)
{
    while(M<N)
        return (M + SumElementsMN (M+1,N));
    return N;
}

Console.WriteLine(SumElementsMN(M, N));