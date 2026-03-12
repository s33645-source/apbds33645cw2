// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Commit1");

Console.WriteLine("Commit2");


Console.WriteLine("Commit3");


Console.WriteLine("cat: ฅ^•ﻌ•^ฅ");
static double CalculateAverage(int[] values)
{
    if (values.Length == 0) return 0;
    double a = 0;
    for (int i = 0; i < values.Length; i++)
    {
        a+=values[i];
    }
    return a / values.Length;
}

static int CalculateMax(int[] values){
int max = values[0];
for (int i = 1; i < values.Length; i++)
{
    if (values[i] > max)
        max = values[i];
}
return max;
}

static int CalculateNotMin(int[] values)
{
    return 1;
}