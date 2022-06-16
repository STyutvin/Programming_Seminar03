internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 8. Напишите программу, который выводит на консоль таблицу умножения от 1 до n, где n задаётся случайно от 2 до 100.
        Random rnd = new Random();
        int n = rnd.Next(2, 100);
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{n} x {i} = {n * i}");
            Console.WriteLine();
        }
    }
}
//Данная задача была в разделе задач повышенной сложности... Надеюсь, что условие задачи я понял правильно.