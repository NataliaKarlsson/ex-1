namespace ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 to 10: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}