internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 2. Дано трёх значное число N. Определить кратна ли трём сумма всех его цифр.
        Console.Write("Введите трехзначное число: ");
        int numeric = Convert.ToInt32(Console.ReadLine());
        if (numeric > 99 && numeric < 1000)
        {
            int number1 = numeric / 100;
            int number2 = numeric / 10 % 10;
            int number3 = numeric % 10;
            if ((number1 + number2 + number3) % 3 == 0)
            {
                Console.WriteLine($"Сумма цифр числа {numeric} кратна 3.");
            }
            else
            {
                Console.WriteLine($"Сумма цифр числа {numeric} некратна 3.");
            }
        }
        else
        {
            Console.WriteLine("Число должно быть трехзначным.");
        }
    }
}