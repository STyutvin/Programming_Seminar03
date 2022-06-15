internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 3. Дано трёх значное число N. Определить, есть ли среди его цифр 4 или 7.
        Console.Write("Введите трехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 99 && number < 1000)
        {
            int digit1 = number / 100;
            int digit2 = number / 10 % 10;
            int digit3 = number % 10;

            if (digit1 == 4 || digit1 == 7 || digit2 == 4 || digit2 == 7 || digit3 == 4 || digit3 == 7)
            {
                Console.WriteLine("Введенное число содержит цифру 4 или 7");
            }
            else
            {
                Console.WriteLine("Введенное число не содержит цифру 4 или 7");
            }
        }
        else
        {
            Console.WriteLine("Число должно быть трехзначным. Запустите программу снова.");
        }
    }
}