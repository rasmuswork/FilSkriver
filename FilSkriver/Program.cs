
string fileName = "empty_file.txt"; // Specify the desired file name

try
{
    // Get the user's home directory
    string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

    // Combine the user's home directory with the file name
    string filePath = Path.Combine(userDirectory, fileName);

    // Create the empty text file
    File.WriteAllText(filePath, String.Empty);

    Console.WriteLine("Empty text file created successfully!");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}


int x = 0;
while (true) 
{
    Console.Clear();
    Console.WriteLine(x);
    x++;
    System.Threading.Thread.Sleep(1000);
}