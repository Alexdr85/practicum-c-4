//задача 24: Напишите программу, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А.
// 7->28
// 4->10
// 8->36

double f(idouble  n)
{
    return ((1+n)/2*n);
}

Console.Clear();
double  a = Convert.ToDouble (Console.ReadLine());
Console.WriteLine(f(a));