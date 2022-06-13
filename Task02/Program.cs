internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        int[] pointX = new int[2];
        int[] pointY = new int[2];
        int[] pointZ = new int[2];
        double distance;
        Console.Write("Введите координату Х1 первой точки: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату Y1 первой точки: ");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату Z1 первой точки: ");
        int z1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату Х2 второй точки: ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату Y2 второй точки: ");
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату Z2 второй точки: ");
        int z2 = Convert.ToInt32(Console.ReadLine());
        pointX[0] = x1;
        pointX[1] = x2;
        pointY[0] = y1;
        pointY[1] = y2;
        pointZ[0] = z1;
        pointZ[1] = z2;
        distance = Math.Sqrt(Math.Pow(pointX[1] - pointX[0], 2) + Math.Pow(pointY[1] - pointY[0], 2) + Math.Pow(pointZ[1] - pointZ[0], 2));
        Console.WriteLine($"Длина отрезка равна: {distance}");
    }
}