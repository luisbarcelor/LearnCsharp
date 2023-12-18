namespace Sample.Module4;

public class Casting
{
    static void Start()
    {
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        string message = "";
        decimal total = 0m;
        
        foreach (var value in values)
        {
            decimal parsedNum;
            
            if (decimal.TryParse(value, out parsedNum))
                total += parsedNum;
            else
                message += value;
        }
        
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {total}");

        int value1 = 12;
        decimal value2 = 6.2m;
        float value3 = 4.3f;
        
        int result1 = Convert.ToInt32(value1 / value2);
        // Hint: You need to round the result to nearest integer (don't just truncate)
        Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
        
        decimal result2 = value2 / (decimal)value3;
        // Your code here to set result2
        Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");
        
        float result3 = value3 / value1;
        // Your code here to set result3
        Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
    }
}