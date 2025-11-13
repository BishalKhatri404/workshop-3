namespace task5
{
    internal class Program
    {
        static void Main()
        {
            // 1. Ask the user to input a number N and calculate sum from 1 to N
            Console.Write("Enter a number N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum from 1 to " + N + " is: " + sum);


            // 2. Print numbers from 1 to 20 using while loop
            // Skip (continue) multiples of 4
            // Stop (break) when number is 15
            int num = 1;
            while (num <= 20)
            {
                if (num % 4 == 0)
                {
                    num++;
                    continue;
                }

                if (num == 15)
                    break;

                Console.WriteLine(num);
                num++;
            }


            // 3. Find sum of all elements in an array using foreach loop
            int[] numbers = { 2, 4, 6, 8, 10 };
            int total = 0;

            foreach (int n in numbers)
            {
                total += n;
            }

            Console.WriteLine("Sum of array elements is: " + total);
        }
    }
}
