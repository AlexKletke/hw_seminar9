//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("enter N > 0: ");
int N = int.Parse(Console.ReadLine());
string NaturNumbers (int N)
{
    if(N == 1){
        return N.ToString();
    }
    return (N + ", " + NaturNumbers (N-1));
}

Console.WriteLine(NaturNumbers(N));