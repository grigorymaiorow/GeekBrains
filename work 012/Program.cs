Console.WriteLine("Введи число");
int num = Convert.ToInt32(Console.ReadLine());

if ( num < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}

while ( num > 1000)
{
    num = num / 10;
}
int res = num % 10;
System.Console.WriteLine(res);