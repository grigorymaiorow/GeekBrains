Console.WriteLine("Введи число");
int N = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i <= N)
{
    int b = i % 2;

    if ( b == 0 )
    {
        Console.Write($"{i}, " );
    }
i++;
}

