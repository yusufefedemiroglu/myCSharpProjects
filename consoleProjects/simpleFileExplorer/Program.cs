namespace simpleFileExplorer
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory(); DisplayDirectoryContents(currentDirectory);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
        static void DisplayDirectoryContents(string path)
        {
            Console.WriteLine($"Contents of {path}");

            try
            {
                //Display Directories
                string[] directories = Directory.GetDirectories(path);
                foreach (var directory in directories)
                {
                    Console.WriteLine($"[D] {Path.GetFileName(directory)}");
                }

                //Display Files
                string[] files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    Console.WriteLine($"[F] {Path.GetFileName(file)}");
                }

            }
            catch(Exception error)
            {
                Console.WriteLine($"Error: {error.Message}");
            }

            Console.WriteLine();
            Console.Write("Enter a directory to navigate (or type '..' to go up): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "..")
            {
                //Navigate up one level
                string parentDirectory = Directory.GetParent(path)?.FullName;
                if (parentDirectory != null)
                {
                    DisplayDirectoryContents(parentDirectory);
                }
            }
            else
            {
                //Navigate to the selected directory
                string selectedDirectory = Path.Combine(path, input);
                if (Directory.Exists(selectedDirectory))
                {
                    DisplayDirectoryContents(selectedDirectory);
                }
                else
                {
                    Console.WriteLine("Invalid directory.");
                }
            }
            
        }
    }
}