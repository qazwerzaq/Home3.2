// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты первого числа : ");
Console.WriteLine("X");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine("Y");
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Z");
double Z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второго числа : ");
Console.WriteLine("X");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine("Y");
double Y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Z");
double Z2 = double.Parse(Console.ReadLine());
double distance = 0;
distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
Console.WriteLine($"расстояние между двумя точками: {Math.Round(distance, 3)}");
