Console.Clear();
Console.WriteLine("Please, enter 1-st number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter 2-nd number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter 3-rd number");
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max)
{
        max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("maximest number: " + max);
