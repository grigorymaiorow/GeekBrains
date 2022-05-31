System.Console.WriteLine("Введите число");
System.Console.Write($"n = ");
int n = int.Parse(System.Console.ReadLine());
int i = 1;

while (i <= n )
{
    System.Console.Write(i);
    System.Console.Write("^3 = ");
    System.Console.WriteLine(i*i*i);;
    i++;
}