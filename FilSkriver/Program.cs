

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Create an empty text file or file with custom text");
    Console.WriteLine("2. Show user folder path");
    Console.WriteLine("3. Exit");

    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            CreateEmptyTextFile();
            break;
        case "2":
            ShowUserFolderPath();
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }

    Console.WriteLine();
}


    static void CreateEmptyTextFile()
{
    Console.Write("Enter the file name: ");
    string fileName = Console.ReadLine();

    try
    {
        // Get the user's home directory
        string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        // Combine the user's home directory with the file name
        string filePath = Path.Combine(userDirectory, fileName);

        // Create the empty text file
        File.WriteAllText(filePath, string.Empty);

        Console.WriteLine("text file created successfully!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}

static void ShowUserFolderPath()
{
    // Get the user's home directory
    string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

    Console.WriteLine($"User folder path: {userDirectory}");
}
