System.Console.WriteLine("Введите первое число");
int A = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int B = int.Parse(System.Console.ReadLine());

double C = Math.Pow(A, B);
System.Console.Write("Число А в степени числа В = ");
System.Console.WriteLine(C);