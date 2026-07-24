public class Program
{
    public static void Main()
    {
        Console.WriteLine("Test 1: OpenFile(\"existing.txt\")");
        OpenFile("ExistingTestFile.txt"); // Need this file inside Lab6/Exercise5/bin/Debug/net8.0 because for some reason this is the path that the code is looking into for finding the file.
        Console.WriteLine();

        Console.WriteLine("Test 2: OpenFile(\"nonexistent.txt\")");
        OpenFile("nonexistent.txt");
        Console.WriteLine();
    }

    public static void OpenFile(string fileName)
    {
        try
        {
            var file = File.OpenRead(fileName);
            file.Close();
            Console.WriteLine("File opened successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
