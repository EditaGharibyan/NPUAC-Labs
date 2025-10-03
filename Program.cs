namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab2
            /*Console.WriteLine("What is Your Name");
            string? name = Console.ReadLine();
            Console.WriteLine("How old are you");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"My name is {name}.I`m {age}");*/
            Console.WriteLine($"Enter first Number");
            Console.WriteLine($"Enter second Number");
            int firstNumber = Int32.Parse(Console.ReadLine());
            int secondNumber = Int32.Parse(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            Console.WriteLine(firstNumber+secondNumber);
        }
    }
} 
