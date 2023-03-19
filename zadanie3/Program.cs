





int f(int n)
{

    int res = 1;
    for (int i = 2; i <= n; i++)
    res *= i;
    return res;
}

Console.Clear();
Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(number));