namespace Sample;

public class FizzBuzz
{
    public static void Start()
    {
        // for (int i = 1; i <= 100; i++)
        // {
        //     if (i % 3 == 0 && i % 5 == 0)
        //         Console.WriteLine($"{i} FizzBuzz");
        //     
        //     else if (i % 3 == 0)
        //         Console.WriteLine($"{i} Fizz");
        //     
        //     else if (i % 5 == 0)
        //         Console.WriteLine($"{i} Buzz");
        //     
        //     else
        //         Console.WriteLine(i);
        // }
        
        for (int i = 1; i <= 100; i++)
        {
            Console.Write($"{i} ");
            
            if (i % 3 == 0) 
                Console.Write("Fizz");
            
            if (i % 5 == 0) 
                Console.Write("Buzz");
            
            Console.Write("\n");
        }
    }
}