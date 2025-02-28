// Console.BackgroundColor = ConsoleColor.DarkGreen;
// Console.ForegroundColor = ConsoleColor.White;

Boolean isRunning = true;
List<string> guests = new List<string> { }; //list of guests

static void showMenu()
{
    Console.WriteLine("Guest admin system");
    Console.WriteLine("1. View guest list");
    Console.WriteLine("2. Add guest");
    Console.WriteLine("3. Remove guest");
    Console.WriteLine("4. Check if guest is valid");
    Console.WriteLine("5. Exit");
}

while (isRunning)
{
    showMenu();
    string menuChoice = Console.ReadLine();

    switch (menuChoice)
    {
        case "1":
            if (guests.Count() == 0)
            {
                Console.WriteLine("There are no guests!");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, guests)); //prints guest list
            }
            break;

        case "2":
            Console.WriteLine("First name of guest:");
            string firstName = Console.ReadLine();  

            Console.WriteLine("Last name of guest:");
            string lastName = Console.ReadLine();

            string fullName = firstName + ", " + lastName;
            guests.Add(fullName);

            Console.WriteLine($"Successfully added {firstName}, {lastName}!");
            break;

        case "3":
            Console.WriteLine("First name of guest:");
            firstName = Console.ReadLine();

            Console.WriteLine("Last name of guest:");
            lastName = Console.ReadLine();

            fullName = firstName + ", " + lastName;

            if (guests.Contains(fullName))
            {
                guests.Remove(fullName);
                Console.WriteLine($"Successfully deleted {fullName}");
            }
            else
            {
                Console.WriteLine("Invalid name, please try again!");
            }
            break;

        case "4":
            Console.WriteLine("First name of guest:");
            firstName = Console.ReadLine();

            Console.WriteLine("Last name of guest:");
            lastName = Console.ReadLine();

            fullName = $"{firstName}, {lastName}";

            if (guests.Contains(fullName))
            {
                Console.WriteLine($"{fullName} is valid.");
            }
            else
            {
                Console.WriteLine("Invalid name, please try again!");
            }
            break;

        case "5":
            isRunning = false;
            break;
    }
    Console.WriteLine("Go back to menu? y/n");
    string backToMenu = Console.ReadLine();

    if (backToMenu == "y")
    {
        backToMenu = "";
    }
    else if (backToMenu == "n")
    {
        Console.WriteLine("Exiting application...");
        isRunning = false;
    }
    else
    {
        Console.WriteLine("Invalid choice, try again.");
    }
}