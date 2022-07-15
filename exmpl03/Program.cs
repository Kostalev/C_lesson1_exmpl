int a = new Random().Next();
int res = a % 2;

if (res != 0)
{
    Console.WriteLine("число {0} не четное", a);
}
else
{
    Console.WriteLine("число {0} четное", a);
}