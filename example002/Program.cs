// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] coordsA = new double[3];
double[] coordsB = new double[3];
System.Console.Write("Введите Х1: ");
coordsA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Y1: ");
coordsA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Z1: ");
coordsA[2] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Х2: ");
coordsB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Y2: ");
coordsB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Z2: ");
coordsB[2] = Convert.ToInt32(Console.ReadLine());
double res = Math.Sqrt(Math.Pow(coordsB[0] - coordsA[0], 2)
                        + Math.Pow(coordsB[1] - coordsA[1], 2)
                        + Math.Pow(coordsB[2] - coordsA[2], 2));
System.Console.WriteLine(Math.Round(res, 2));