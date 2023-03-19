



int f(int n)
{
    if (n == 0)
        return 1;
 int count = 0;
 while (n > 0)
 {
    n/=10;
    count ++;
 }
 return count;
}

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));