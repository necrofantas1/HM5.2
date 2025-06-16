{
    bool continueProgram = true;

    while (continueProgram) //p.s тут був true :)
    {
        Console.WriteLine("Please enter your number:");
        string userInput = Console.ReadLine();

        try
        {
            int number = Convert.ToInt32(userInput);
            Console.WriteLine($"You entered the number: {number}");

            continueProgram = false;
        }

        catch (FormatException)
        {
            Console.WriteLine("\nInvalid input. Please enter a valid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("\nThe number you entered is too large or too small. Please try again.");
        }

    }

}
            
        