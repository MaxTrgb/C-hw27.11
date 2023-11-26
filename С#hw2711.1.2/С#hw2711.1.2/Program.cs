namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 integers:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");

                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write("Element " + (i + 1) + ": ");
                }
            }

            Console.WriteLine("\nArray elements:");

            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            int max = numbers[0];
            int min = numbers[0];
            int sum = numbers[0];
            int product = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                sum += numbers[i];
                product *= numbers[i];
            }

            Console.WriteLine("\n\nMaximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
            Console.WriteLine("Sum of elements: " + sum);
            Console.WriteLine("Product of elements: " + product);
        }
    }
}
