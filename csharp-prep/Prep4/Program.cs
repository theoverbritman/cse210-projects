using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int numberValue = -1;
        while (numberValue != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when you're finished.");

            string userInput = Console.ReadLine();
            numberValue = int.Parse(userInput);

            if (numberValue != 0)
            {
                numbers.Add(numberValue);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}