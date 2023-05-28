// Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.


Console.Write("Введите координаты первой точки А (x,y,z): ");
string[] point1 = Console.ReadLine().Split(' ');
double x1 = double.Parse(point1[0]);
double y1 = double.Parse(point1[1]);
double z1 = double.Parse(point1[2]);

Console.Write("Введите координаты второй точки В (x,y,z): ");
string[] point2 = Console.ReadLine().Split(' ');
double x2 = double.Parse(point2[0]);
double y2 = double.Parse(point2[1]);
double z2 = double.Parse(point2[2]);

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между точками: {distance}");


