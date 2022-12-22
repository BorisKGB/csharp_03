// Спрашиваем точки у пользователя
// Console.WriteLine("Введите координату X первой точки");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y первой точки");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Z первой точки");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X второй точки");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y второй точки");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Z второй точки");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Или генерируем их
int min = -5;
int max = 5;

int x1 = new Random().Next(min, max + 1);
int y1 = new Random().Next(min, max + 1);
int z1 = new Random().Next(min, max + 1);
int x2 = new Random().Next(min, max + 1);
int y2 = new Random().Next(min, max + 1);
int z2 = new Random().Next(min, max + 1);

Console.WriteLine($"Generated point1 ({x1}, {y1}, {z1})");
Console.WriteLine($"Generated point2 ({x2}, {y2}, {z2})");

// Квадрат расстояния между двумя точками S^2 равен сумме квадратов расстояний между точками
// S^2 = (Ха – Xb)^2 + (Ya – Yb)^2 + (Za – Zb)^2 

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"{result:f2}");

// Tested in https://ciox.ru/distance-between-two-points-in-3d
