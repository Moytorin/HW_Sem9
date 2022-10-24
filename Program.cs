// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введиет число N: ");
// int n = int.Parse(Console.ReadLine()!);

// string Recurs(int n)
// {
//     if (n == 1)
//     {
//         return n.ToString();
//     }
//     return (n + " " + Recurs(n - 1));

// }
// Console.WriteLine(Recurs(n));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введиет число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введиет число N: ");
int n = int.Parse(Console.ReadLine()!);

int sequenceSum(int begin, int end)
{

    if (begin == 0 && end == 0)
    {
        return 0;
    }
    else if (begin == end)
    {
        return begin;
    }
    
    return begin + sequenceSum(begin + 1, end);
}
Console.WriteLine(sequenceSum(m, n));
