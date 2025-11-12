using NullExample;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NullOperations operations = new NullOperations();
            operations.PerformNullChecks();

            // Keep console open
            Console.ReadLine();
        }
    }
}
