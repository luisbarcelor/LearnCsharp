namespace Sample;

public class MonsterHero
{
    public static void Start()
    {
        int herosHealth = 10;
        int monstersHealth = 10;
        
        Random attack = new Random();
        bool gameOver = false;

        Console.WriteLine("Fight started:");
        
        do
        {
            if (herosHealth > 0)
            {
                int herosAttack = attack.Next(1, 11);
                monstersHealth -= herosAttack;
                Console.WriteLine($"Monster was damaged and lost {herosAttack} health now has {monstersHealth} health.");
            }
            else
            {
                gameOver = true;
                Console.WriteLine("Monster wins!");
                continue;
            }

            if (monstersHealth > 0)
            {
                int monstersAttack = attack.Next(1, 11);
                herosHealth -= monstersAttack;
                Console.WriteLine($"Hero was damaged and lost {monstersAttack} health now has {herosHealth} health.");
            }
            else
            {
                gameOver = true;
                Console.WriteLine("Hero wins!");
            }
            
        } while (!gameOver);
    }
}