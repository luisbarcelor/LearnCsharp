namespace Sample;

public class Looping
{
    static void CodeProject1()
    {
        bool validNumber;
        int number;
        
        Console.WriteLine("Enter an integer between 5 and 10:");

        do
        {
            string? input = Console.ReadLine();
            validNumber = int.TryParse(input, out number);

            if (validNumber)
            {
                if (number is < 5 or > 10)
                {
                    Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
                    validNumber = false;
                }
            }
            else
            {
                Console.WriteLine("Sorry, you entered and invalid number, please try again.");
            }
            
        } while (!validNumber);

        Console.WriteLine($"Your input value ({number}) has been accepted.");
    }
    static void CodeProject2()
    {
        string? input;
        bool validInput = false;
        
        do
        {
            Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
            input = Console.ReadLine();

            if (input != null)
            {
                string processedInput = input.Trim().ToLower();
                
                switch (processedInput)
                {
                    case "administrator":
                    case "manager":
                    case "user":
                        validInput = true;
                        break;
                    default:
                        Console.WriteLine($"The role that you entered, \"{input}\" is not valid.");
                        break;
                }
            }

        } while (!validInput);

        Console.WriteLine($"Your input value ({input}) has been accepted.");
    }
    public static void CodeProject3()
    {
        string[] myStrings = ["I like pizza. I like roast chicken. I like salad. Luis Barcelo", "I like all three of the menu choices. Liz Laura"];

        foreach (var myString in myStrings)
        {
            string inputString = myString;
            int periodLocation = 0;

            while (periodLocation != -1)
            {
                string outputSentence; 
                periodLocation = inputString.IndexOf(".");
                
                if (periodLocation > -1)
                {
                    outputSentence = inputString.Remove(periodLocation);
                    inputString = inputString.Substring(periodLocation + 1).TrimStart();
                }
                else
                {
                    outputSentence = inputString.Trim();
                }
                
                Console.WriteLine(outputSentence);
            }
        }
    }
}