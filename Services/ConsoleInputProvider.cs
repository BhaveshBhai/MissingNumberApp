using MissingNumberApp.Interfaces;

namespace MissingNumberApp.Services
{
    public class ConsoleInputProvider : IInputProvider
    {
        public int[] GetInput()
        {
            Console.WriteLine("Enter numbers from 0 to n (excluding one), separated by commas:");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Please enter a valid comma-separated list of integers.");
                return GetInput();
            }

            try
            {
                return input.Split(',')
                            .Select(s => int.Parse(s.Trim()))
                            .ToArray();
            }
            catch
            {
                Console.WriteLine("Input must be integers only. Please try again.");
                return GetInput();
            }
        }
    }
}
