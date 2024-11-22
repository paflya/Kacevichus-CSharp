using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        if (RequestValidNumber("Please enter a number") > 7) Console.WriteLine("Hello");

        Console.WriteLine("Please enter your name");
        if (Console.ReadLine().Contains("John"))
        {
            Console.WriteLine("Hello, John");
        }
        else Console.WriteLine("There is no such name");

        int arraySize = RequestValidNumber("Enter the size of array");
        int[] intArray = new int[arraySize];

        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = RequestValidNumber($"Enter element {i + 1} out of {intArray.Length}");
        }
        List<int> filteredList = intArray.Where(number => number % 3 == 0).ToList();
        Console.WriteLine($"The amount numbers that are multiples of 3: {filteredList.Count}");
        Console.WriteLine(filteredList.ToString());
    }

    private static int RequestValidNumber(string hint)
    {
        bool numberIsEntered = false;
        int number = 0;
        do
        {
            Console.WriteLine(hint);
            numberIsEntered = int.TryParse(Console.ReadLine(), out number);

        } while (!numberIsEntered);

        return number;
    }
}