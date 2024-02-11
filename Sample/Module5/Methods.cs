namespace Sample.Module5;

public class Methods
{
    public static void DisplayRandomNumbers()
    {
        Random random = new Random();

        for (int i = 0; i < 30; i++) 
        {
            Console.Write($"{random.Next(1, 100)} ");
        }

        Console.WriteLine();
    }
}