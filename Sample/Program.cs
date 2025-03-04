﻿namespace Sample;

public class Program
{
    public static void Start()
    {
        
        // the ourAnimals array will store the following: 
        string animalSpecies = "";
        string animalId = "";
        string animalAge = "";
        string animalPhysicalDescription = "";
        string animalPersonalityDescription = "";
        string animalNickname = "";

        // variables that support data entry
        int maxPets = 8;
        string? readResult;
        string menuSelection = "";
        int petCount = 0;
        string anotherPet = "y";
        bool validEntry = false;
        int petAge = 0;

        // array used to store runtime data, there is no persisted data
        string[,] ourAnimals = new string[maxPets, 6];

        // create some initial ourAnimals array entries
        for (int i = 0; i < maxPets; i++)
        {
            switch (i)
            {
                case 0:
                    animalSpecies = "dog";
                    animalId = "d1";
                    animalAge = "2";
                    animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
                    animalNickname = "lola";
                    break;

                case 1:
                    animalSpecies = "dog";
                    animalId = "d2";
                    animalAge = "9";
                    animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                    animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                    animalNickname = "loki";
                    break;

                case 2:
                    animalSpecies = "cat";
                    animalId = "c3";
                    animalAge = "1";
                    animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
                    animalPersonalityDescription = "friendly";
                    animalNickname = "Puss";
                    break;

                case 3:
                    animalSpecies = "cat";
                    animalId = "c4";
                    animalAge = "?";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";

                    break;

                default:
                    animalSpecies = "";
                    animalId = "";
                    animalAge = "";
                    animalPhysicalDescription = "";
                    animalPersonalityDescription = "";
                    animalNickname = "";
                    break;

            }

            ourAnimals[i, 0] = "ID #: " + animalId;
            ourAnimals[i, 1] = "Species: " + animalSpecies;
            ourAnimals[i, 2] = "Age: " + animalAge;
            ourAnimals[i, 3] = "Nickname: " + animalNickname;
            ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
        }

        // display the top-level menu options
        do
        {
            Console.Clear();

            Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
            Console.WriteLine(" 1. List all of our current pet information");
            Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
            Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
            Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
            Console.WriteLine(" 5. Edit an animal’s age");
            Console.WriteLine(" 6. Edit an animal’s personality description");
            Console.WriteLine(" 7. Display all cats with a specified characteristic");
            Console.WriteLine(" 8. Display all dogs with a specified characteristic");
            Console.WriteLine();
            Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                menuSelection = readResult.ToLower();
            }
            
            switch (menuSelection)
            {
                case "1":
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 0] != "ID #: ")
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(ourAnimals[i, j].ToString());
                            }
                        }
                    }
                    Console.WriteLine("\n\rPress the Enter key to continue");
                    readResult = Console.ReadLine();

                    break;

                case "2":
                    anotherPet = "y";
                    petCount = 0;
                    for (int i = 0; i < maxPets; i++)
                    {
                        if (ourAnimals[i, 0] != "ID #: ")
                        {
                            petCount += 1;
                        }
                    }

                    if (petCount < maxPets)
                    {
                        Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
                    }

                    while (anotherPet == "y" && petCount < maxPets)
                    {
                        do
                        {
                            Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalSpecies = readResult.ToLower();
                                if (animalSpecies != "dog" && animalSpecies != "cat")
                                {
                                    //Console.WriteLine($"You entered: {animalSpecies}.");
                                    validEntry = false;
                                }
                                else
                                {
                                    validEntry = true;
                                }
                            }
                        } while (validEntry == false);
                        
                        animalId = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
                        
                        do
                        {
                            Console.WriteLine("Enter the pet's age or enter ? if unknown");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalAge = readResult;
                                if (animalAge != "?")
                                {
                                    validEntry = int.TryParse(animalAge, out petAge);
                                }
                                else
                                {
                                    validEntry = true;
                                }
                            }
                        } while (validEntry == false);

                        
                        do
                        {
                            Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalPhysicalDescription = readResult.ToLower();
                                if (animalPhysicalDescription == "")
                                {
                                    animalPhysicalDescription = "tbd";
                                }
                            }
                        } while (validEntry == false);
                        
                        do
                        {
                            Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalPersonalityDescription = readResult.ToLower();
                                if (animalPersonalityDescription == "")
                                {
                                    animalPersonalityDescription = "tbd";
                                }
                            }
                        } while (validEntry == false);
                        
                        do
                        {
                            Console.WriteLine("Enter a nickname for the pet");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalNickname = readResult.ToLower();
                                if (animalNickname == "")
                                {
                                    animalNickname = "tbd";
                                }
                            }
                        } while (validEntry == false);
                        
                        ourAnimals[petCount, 0] = "ID #: " + animalId;
                        ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                        ourAnimals[petCount, 2] = "Age: " + animalAge;
                        ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                        ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                        ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                        
                        petCount++;
                        
                        if (petCount < maxPets)
                        {
                            // another pet?
                            Console.WriteLine("Do you want to enter info for another pet (y/n)");
                            do
                            {
                                readResult = Console.ReadLine();
                                if (readResult != null)
                                {
                                    anotherPet = readResult.ToLower();
                                }

                            } while (anotherPet != "y" && anotherPet != "n");
                        }
                        //NOTE: The value of anotherPet (either "y" or "n") is evaluated in the while statement expression - at the top of the while loop
                    }

                    if (petCount >= maxPets)
                    {
                        Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                        Console.WriteLine("Press the Enter key to continue.");
                        readResult = Console.ReadLine();
                    }

                    break;

                case "3":
                    // Ensure animal ages and physical descriptions are complete
                    Console.WriteLine("Challenge Project - please check back soon to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "4":
                    // Ensure animal nicknames and personality descriptions are complete
                    Console.WriteLine("Challenge Project - please check back soon to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "5":
                    // Edit an animal’s age");
                    Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "6":
                    // Edit an animal’s personality description");
                    Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                
                case "7":
                    // Display all cats with a specified characteristic
                    Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                case "8":
                    // Display all dogs with a specified characteristic
                    Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;

                default:
                    break;
            }

        } while (menuSelection != "exit");
    }
}
