Console.WriteLine("Input x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) System.Console.WriteLine("1 quarter");
else if (x < 0 && y > 0) System.Console.WriteLine("2 quarter");
else if (x < 0 && y < 0) System.Console.WriteLine("3 quarter");
else if (x > 0 && y < 0) System.Console.WriteLine("4 quarter");