//Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Sum(int m, int n)
{
    System.Console.Write(Res(m - 1, n));
}

int Res(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Res(m, n);
        return res;
    }
}

Sum(m, n);