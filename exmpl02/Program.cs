int a = new Random().Next();
int b = new Random().Next();
int c = new Random().Next();

Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;


Console.Write("max = {0}", max);
