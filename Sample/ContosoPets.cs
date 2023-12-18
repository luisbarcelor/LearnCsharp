namespace Sample;

public class ContosoPets
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
        string menuSelection = "";
        int maxPets = 8;
        bool validEntry;
        
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

            string? readResult = Console.ReadLine();
            
            if (readResult != null)
                menuSelection = readResult.Trim().ToLower();

            switch (menuSelection)
            {
                case "1":
                    // List all of our current pet information
                    for (int i = 0; i < maxPets; i++) 
                    {
                        if (ourAnimals[i, 0] != "ID #: ")
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 6; j++) 
                            {
                                Console.WriteLine(ourAnimals[i, j]);
                            }
                        }
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "2":
                    // Add a new animal friend to the ourAnimals array
                    string anotherPet = "y";
                    int petCount = 0;

                    for (int i = 0; i < maxPets; i++) 
                    {
                        if (ourAnimals[i, 0] != "ID #: ")
                            petCount++;
                    }

                    if (petCount < maxPets)
                        Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {maxPets - petCount} more.");
                    
                    while (anotherPet == "y" && petCount < maxPets)
                    {
                        do
                        {
                            validEntry = false;
                            Console.WriteLine("\nEnter 'dog' or 'cat' to begin a new entry:");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalSpecies = readResult.Trim().ToLower();

                                if (animalSpecies != "dog" && animalSpecies != "cat")
                                {
                                    validEntry = false;
                                }
                                else
                                {
                                    validEntry = true;
                                }
                            }
                        } while (!validEntry);
                        
                        animalId = animalSpecies.Substring(0, 1) + (petCount + 1);
                        
                        do
                        {
                            validEntry = false;
                            Console.WriteLine("Enter pet's age or enter ? if unknown");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalAge = readResult.Trim();
                                if (animalAge != "?")
                                {
                                    validEntry = int.TryParse(animalAge, out _);
                                }
                                else
                                {
                                    validEntry = true;
                                }
                            }
                        } while (!validEntry);

                        do
                        {
                            Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalPhysicalDescription = readResult.Trim().ToLower();
                                if (animalPhysicalDescription == "")
                                {
                                    animalPhysicalDescription = "tbd";
                                }
                            }
                        } while (animalPhysicalDescription == "");

                        do
                        {
                            Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalPersonalityDescription = readResult.Trim().ToLower();
                                if (animalPersonalityDescription == "")
                                {
                                    animalPersonalityDescription = "tbd";
                                }
                            }
                        } while (animalPersonalityDescription == "");

                        do
                        {
                            Console.WriteLine("Enter a nickname for the pet");
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                animalNickname = readResult.Trim().ToLower();
                                if (animalNickname == "")
                                {
                                    animalNickname = "tbd";
                                }
                            }
                        } while (animalNickname == "");
                        
                        ourAnimals[petCount, 0] = "ID #: " + animalId;
                        ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                        ourAnimals[petCount, 2] = "Age: " + animalAge;
                        ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                        ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                        ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;
                        
                        petCount++;
                        
                        if (petCount < maxPets)
                        {
                            Console.WriteLine("Do you want to enter info for another pet (y/n)");
                            do
                            {
                                readResult = Console.ReadLine();
                                
                                if (readResult != null)
                                    anotherPet = readResult.Trim().ToLower();
                                
                            } while (anotherPet != "y" && anotherPet != "n");
                        }
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
                    for (int i = 0; i < maxPets; i++)
                    {
                        animalId = ourAnimals[i, 0];
                        if (animalId == "ID #: ") continue;
                        
                        
                        animalAge = ourAnimals[i, 2];
                        if (animalAge is "Age: " or "Age: ?")
                        {
                            do
                            {
                                validEntry = false;
                                Console.WriteLine($"Enter an age for {animalId}");
                                readResult = Console.ReadLine();
                                
                                if (readResult == null) continue;
                                
                                animalAge = readResult.Trim().ToLower();
                                validEntry = int.TryParse(animalAge, out _);
                            } while (!validEntry);

                            ourAnimals[i, 2] = "Age: " + animalAge;
                            Console.WriteLine($"\nAn age has been saved for {animalId}\n");
                        }
                        
                        
                        animalPhysicalDescription = ourAnimals[i, 4];
                        if (animalPhysicalDescription is "Physical description: " or "Physical description: tbd")
                        {
                            do
                            {
                                validEntry = false;
                                Console.WriteLine($"Enter a physical description for {animalId} (size, color, breed, gender, weight, housebroken)");
                                readResult = Console.ReadLine();

                                if (readResult == null) continue;

                                animalPhysicalDescription = readResult.Trim().ToLower();
                                validEntry = animalPhysicalDescription.Length > 10;

                                if (!validEntry)
                                    Console.WriteLine("A physical description of at least 10 characters is mandatory\n");
                                
                            } while (!validEntry);
                            
                            ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                            Console.WriteLine($"\nA physical description has been saved for {animalId}\n");
                        }
                    }

                    Console.WriteLine("\nAge and physical description fields are complete for all of our friends.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "4":
                    // Ensure animal nicknames and personality descriptions are complete
                    for (int i = 0; i < maxPets; i++)
                    {
                        animalId = ourAnimals[i, 0];
                        if (animalId == "ID #: ") continue;

                        animalNickname = ourAnimals[i, 3];
                        if (animalNickname is "Nickname: " or "Nickname: tbd")
                        {
                            do
                            {
                                validEntry = false;
                                Console.WriteLine($"Enter a nickname for {animalId}");
                                readResult = Console.ReadLine();

                                if (readResult == null) continue;

                                animalNickname = readResult.Trim().ToLower();
                                validEntry = animalNickname.Length > 3;
                                
                                if (!validEntry)
                                    Console.WriteLine("A pet's nickname must contain at least 3 characters\n");

                            } while (!validEntry);

                            ourAnimals[i, 3] = "Nickname: " + animalNickname;
                            Console.WriteLine($"\nA nickname has been saved for {animalId}\n");
                        }

                        animalPersonalityDescription = ourAnimals[i, 5];
                        if (animalPersonalityDescription is "Personality: " or "Personality: tbd")
                        {
                            do
                            {
                                validEntry = false;
                                Console.WriteLine($"Enter a personality description for {animalId} (likes or dislikes, tricks, energy level)");
                                readResult = Console.ReadLine();

                                if (readResult == null) continue;

                                animalPersonalityDescription = readResult.Trim().ToLower();
                                validEntry = animalPersonalityDescription.Length > 10;
                                
                                if (!validEntry)
                                    Console.WriteLine("A pet's personality description of at least 10 characters is mandatory\n");

                            } while (!validEntry);

                            ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                            Console.WriteLine($"\nA personality description has been saved for {animalId}\n");
                        }
                    }

                    Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "5":
                    // Edit an animal's age
                    Console.WriteLine($"You selected option 5");
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "6":
                    // Edit an animal's personality description
                    Console.WriteLine($"You selected option 6");
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "7":
                    // Display all cats with a specified characteristic
                    Console.WriteLine($"You selected option 7");
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                case "8":
                    // Display all dogs with a specified characteristic
                    Console.WriteLine($"You selected option 8");
                    Console.WriteLine("this app feature is coming soon - please check back to see progress.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
                default:
                    if (menuSelection == "exit") continue;
                    
                    Console.WriteLine("Your selection is not a menu option. Try again!");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                    break;
            }

        } while (menuSelection != "exit");
    }
}