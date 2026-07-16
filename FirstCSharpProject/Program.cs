namespace FirstCSharpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Countdown Timer ");
            Console.Write("Enter a starting number: ");
            int startNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = startNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!!");
        }
    }
}
