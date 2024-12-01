Console.Write("Введите значение x: ");
double x = double.Parse(Console.ReadLine());
double y = 1.8 * Math.Pow(x, 2) - Math.Sin(10 * x);
Console.WriteLine($"При x = {x}, y = {y}");