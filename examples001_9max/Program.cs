int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result
}

int a1 = new Random().Next(1,999);
Console.WriteLine (a1);
int b1 = new Random().Next(1,999);
Console.WriteLine (b1);
int c1 = new Random().Next(1,999);
Console.WriteLine (c1);
int a2 = new Random().Next(1,999);
Console.WriteLine (a2);
int b2 = new Random().Next(1,999);
Console.WriteLine (b2);
int c2 = new Random().Next(1,999);
Console.WriteLine (c2);
int a3 = new Random().Next(1,999);
Console.WriteLine (a3);
int b3 = new Random().Next(1,999);
Console.WriteLine (b3);
int c3 = new Random().Next(1,999);
Console.WriteLine (c3);

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine (max);