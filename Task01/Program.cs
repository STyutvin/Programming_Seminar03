internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        Console.Write("Введи пятизначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        string numText = Convert.ToString(num);
        if (numText.Length > 5 || numText.Length < 5)
        {
            Console.WriteLine("Число должно быть пятизначным.");
        }
        else if (numText[0] == numText[4] && numText[1] == numText[3])
        {
            Console.WriteLine($"Число {num} является палиндромом.");
        }
        else
        {
            Console.WriteLine($"Число {num} не является палиндромом.");
        }
    }
}