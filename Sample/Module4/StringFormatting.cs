namespace Sample.Module4;

public class StringFormatting
{
    public static void Basics()
    {
        string first = "Hello";
        string second = "World";
        string result1 = string.Format("{1} {0}!", first, second);
        Console.WriteLine(result1);
        Console.WriteLine("{0} {0} {0}!", first, second);
        Console.WriteLine("---------------------");

        decimal price = 123.45m;
        int discount = 50;

        Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        decimal measurement = 123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N4} units");
        decimal tax = 0.36785m;
        Console.WriteLine($"Tax rate: {tax:P2}");
        Console.WriteLine("--------------------");

        decimal originalPrice = 67.55m;
        decimal salePrice = 59.99m;

        string myDiscount = $"You saved {(originalPrice - salePrice):C2} off the regular {originalPrice:C2} price. ";
        myDiscount += $"A discount of {((originalPrice - salePrice) / originalPrice):P2}!";
        Console.WriteLine(myDiscount);    
    }

    public static void Padding()
    {
        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;
        
        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine($"    Shares: {productShares:N3} Product");
        Console.WriteLine($"        Sub Total: {subtotal:C}");
        Console.WriteLine($"            Tax: {taxPercentage:P2}");
        Console.WriteLine($"        Total Billed: {total:C}");
            
        string paymentId = "769C";
        string payeeName = "Mr. Stephen Ortega";
        string paymentAmount = "$5,000.00";

        var formattedLine = paymentId.PadRight(6);
        formattedLine += payeeName.PadRight(24);
        formattedLine += paymentAmount.PadLeft(10);

        Console.WriteLine("\n\n1234567890123456789012345678901234567890");
        Console.WriteLine(formattedLine);
    }

    public static void ChallengeLetter()
    {
        var customerName = "Ms. Barros";
        var currentShares = 2975000;
            
        var currentProduct = "Magic Yield";
        var currentReturn = 0.1275m;
        var currentProfit = 55000000.0m;

        var newProduct = "Glorious Future";
        var newReturn = 0.13125m;
        var newProfit = 63000000.0m;

        Console.WriteLine($"Dear {customerName},");
        Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
        Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
        Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.\n");
        Console.WriteLine("Here's a quick comparison:\n");

        var comparisonMessage = "";
            
        comparisonMessage += currentProduct.PadRight(20);
        comparisonMessage += $"{currentReturn:P2}".PadRight(10);
        comparisonMessage += $"{currentProfit:C}";
        comparisonMessage += "\n";
        comparisonMessage += newProduct.PadRight(20);
        comparisonMessage += $"{newReturn:P2}".PadRight(10);
        comparisonMessage += $"{newProfit:C}";
            
        Console.WriteLine(comparisonMessage);
    }
}