using System;
using System.IO;

class Creator 
{
    public static void CreateDirectory() 
    {
        // Specify the directory you want to manipulate.
        string path = @"\\sscowbfs03\public\toms\cadd\Rendition\Exception\";

        try 
        {
            // Determine whether the directory exists.
            if (Directory.Exists(path)) 
            {
                Console.WriteLine("That path exists already.");
                return;
            }

            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(path);
            Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

        } 
        catch (Exception e) 
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        } 
        finally {}
    }
}