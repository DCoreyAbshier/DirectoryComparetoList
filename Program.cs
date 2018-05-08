using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DrawingConsolidationProject
{
    public enum command
    {
        compare = 0, move, exit
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome please type a command below and press enter to begin.");
            Console.WriteLine("compare or move or exit");
            var input = Console.ReadLine();
            Enum.TryParse(input, out command usercommand);                                             
            
            switch (usercommand)
            {
                case command.compare:
                {
                    Compare();
                    break;
                }
                case command.move:
                {
                    Move();
                    break;
                }
                case command.exit:
                {
                    Exit();
                    break;
                }
            }

        }

        private static void Exit()
        {
            Environment.Exit(0);
        }

        private static void Move()
        {
            throw new NotImplementedException();
        }

        private static void Compare()
        {

            Console.Clear();
            Console.WriteLine("Please input location of .txt file list");
            var listPath = Console.ReadLine();
            var rougeDrawings = File.ReadAllLines(listPath);
            var directoryPath = @"\\SomeServer\SomeDirectory";
            var drawingFiles = GetDrawingFiles(directoryPath);

            var results = rougeDrawings.ToList().Except(drawingFiles.ToList());

            foreach(var result in results)
            {
                Console.WriteLine(result);
            }

        }

        private static IEnumerable<string> GetDrawingFiles(string directoryPath)
        {
            return Directory.GetFiles(directoryPath, "*.??f", SearchOption.AllDirectories)
                            .ToList()
                            .Select(x => x.Split('.').First());
        }
    }
    
}
