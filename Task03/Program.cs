internal partial class Program
{
    private static void Main(string[] args)
    {
        //Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        Console.Write("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        while (i < n)
        {
            i++;
            Console.WriteLine(i * i * i);
        }
    }
}