class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Write your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine($"Result of division: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter valid integers.");
        }
    }
}
