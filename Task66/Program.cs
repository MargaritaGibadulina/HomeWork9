/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
Sum(m, n);

int Sum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Sum(m, n);
        return res;
    }
    
}

Console.Write($"Сумма натуральных элементов от M до N равна {Sum(m - 1, n)}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}