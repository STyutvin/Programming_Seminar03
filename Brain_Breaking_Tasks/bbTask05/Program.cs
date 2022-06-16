internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 5. На вход подаётся число n > 4, указывающее длину пароля. Создайте метод, генерирующий пароль заданной длины. В пароле обязательно использовать цифру, букву и специальный знак.
        Console.Write("Enter the desired password length: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] letters = { "a", "b", "c", "d", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string[] symbols = { "~", "@", "#", "$", "%", "^", "&", "*", "_" };
        string[] password = new string[n];
        if (n > 4)
        {
            string[] signs = new string[3];
            signs[0] = letters[new Random().Next(0, letters.Length)];
            signs[1] = numbers[new Random().Next(0, numbers.Length)];
            signs[2] = symbols[new Random().Next(0, symbols.Length)];
            Console.Write("Suggested password: ");
            for (int i = 0; i < n; i++)
            {
                password[i] = signs[new Random().Next(0, signs.Length)];
                Console.Write(password[i]);
            }
        }
        else
        {
            Console.Write("The password length must be more than 4 symbols.");
        }
    }
}