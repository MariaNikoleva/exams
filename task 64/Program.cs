// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int count = 1;
void RoadToNumber(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        RoadToNumber(n, count + 1);
        System.Console.Write(count + " ");
    }
}
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
RoadToNumber(number, count);