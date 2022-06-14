internal partial class Program
{
    private static void Main(string[] args)
    {
        //Задача 4. Дан массив длиной 10 элементов. Заполнить его числами от 1 до 10.
        Random rnd = new Random();
        int[] array = { rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10) };
        int i = 0;
        Console.Write("[ ");
        while (i < 10)
        {
            Console.Write(array[i] + " ");
            i++;
        }
        Console.Write("]");
    }
}