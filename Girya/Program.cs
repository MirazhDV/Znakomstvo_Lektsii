int a = 2;
int b = 4;
int c = 1;
int d = 12;
int e = 8;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write ("Max = ");
Console.WriteLine (max);