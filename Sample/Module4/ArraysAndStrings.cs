namespace Sample.Module4;

public class ArraysAndStrings
{
    public static void Pallets()
    {
        string[] pallets = ["B14", "A11", "B12", "A13"];
        Console.WriteLine("Sorted...");
        Array.Sort(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"--- {pallet}");
        }
            
        Console.WriteLine("\nReversed...");
        Array.Reverse(pallets);
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"--- {pallet}");
        }
            
        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"\nClearing 2... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"--- {pallet}");
        }
            
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"\nRezising 6 ... count: {pallets.Length}");
            
        pallets[4] = "C01";
        pallets[5] = "C02";
            
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"--- {pallet}");
        }
            
        Array.Resize(ref pallets, 3);
        Console.WriteLine($"\nResizeing 3 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"--- {pallet}");
        }
    }

    public static void SplitJoin()
    {
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
            
        Array.Reverse(valueArray);
        //string reversedValue = new string(valueArray);
        string reversedValue = string.Join('-', valueArray);

        Console.WriteLine(reversedValue);

        string[] items = reversedValue.Split('-');
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public static void ReverseWords()
    {
        string sentence = "The quick brown fox jumps over the lazy dog";
        string[] words = sentence.Split(" ");
        string[] wordsReversed = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            char[] letters = words[i].ToCharArray();
            Array.Reverse(letters);
            wordsReversed[i] = new string(letters);
        }

        string finalSentence = string.Join(' ', wordsReversed);
        Console.WriteLine(finalSentence);
    }

    public static void ParseOrders()
    {
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        string[] orders = orderStream.Split(',');
        Array.Sort(orders);
        
        foreach (var order in orders)
        {
            if (order.Length != 4)
                Console.WriteLine($"{order}\t- Error");
            else
                Console.WriteLine(order);
        }
    }

}