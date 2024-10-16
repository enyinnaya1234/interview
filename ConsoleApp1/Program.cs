using System;
namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Declare and initializing the variables
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;

            // Print the values of the variables to the console
            Console.WriteLine($"Name: {name}, Age: {age}, Is Admin: {isAdmin}");

            // Task 2: Determine if a number is even or odd
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            // Task 3: Print out numbers from 1 to 10 
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Task 4: Sum and print elements of an array
            int[] numbersArray = { 2, 4, 6, 8, 10 };
            int sum = 0;

            // Use foreach to iterate over the array and calculate the sum
            foreach (int num in numbersArray)
            {
                Console.WriteLine(num);
                sum += num;
            }

            Console.WriteLine($"Sum of array elements: {sum}");

            // Task 5: Greet method
            Greet("Alice");
        }

        // Greet method that prints a personalized greeting message
        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
