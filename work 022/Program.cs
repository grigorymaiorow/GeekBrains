﻿System.Console.WriteLine("Ведите x1");
System.Console.Write($"x1=");
int x1 = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Ведите y1");
System.Console.Write($"y1=");
int y1 = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Ведите z1");
System.Console.Write($"z1=");
int z1 = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Ведите x2");
System.Console.Write($"x2=");
int x2 = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Ведите y2");
System.Console.Write($"y2=");
int y2 = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Ведите z2");
System.Console.Write($"z2=");
int z2 = int.Parse(System.Console.ReadLine());

double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
System.Console.Write("Расстояние между точками равно ");
System.Console.WriteLine(length);