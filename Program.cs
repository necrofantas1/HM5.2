using System.ComponentModel;

while (true)

{
    Console.WriteLine("Please enter a number:");
    string userInput = Console.ReadLine();

    {
        try
        {
            int number = Convert.ToInt32(userInput);
            Console.WriteLine($"\nYou entered the number: {number}");

            break;
        }

        catch (FormatException)
        {
            Console.WriteLine("The input was not in a correct format. Please enter a valid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("\nThe number is too large or too small for an Int32. Please enter a valid number.");
        }

    }

}
