using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DrawingConsolidationProject
{
    class DrawingCargo
    {        
        public string CargoPath {get;set;}
        public string CargoLocation {get;set;}
        public string CargoType {get;set;}
        public string CargoID {get;set;}
        public string CargoName {get;set;}
    }
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
            Console.Clear();
            Console.WriteLine("Input directory path for file that need to be moved");
            var pathToCargo = Console.ReadLine();
            Console.WriteLine("Input directory path for destination");
            var cargoDestination = Console.ReadLine();
            var pendingCargo = GetCargoFromDirectory(pathToCargo);
            var startTime = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");
            File.AppendAllText(@"c:\temp\MoveLog.txt", "-----------------------------------------------------" + Environment.NewLine);
            File.AppendAllText(@"c:\temp\MoveLog.txt", "Move initalized " + startTime + Environment.NewLine );
            File.AppendAllText(@"c:\temp\MoveLog.txt", "-----------------------------------------------------" + Environment.NewLine);

            foreach(var crate in pendingCargo)
            {
                
                var destination = Path.Combine(cargoDestination, crate.CargoName);
                try
                {
                    File.Copy(crate.CargoPath, destination, false);
                    var moveResults = crate.CargoName + " moved successfully ";
                    File.AppendAllText(@"c:\temp\MoveLog.txt", moveResults + Environment.NewLine);                     
                }
                catch(IOException copyError)
                {
                    File.AppendAllText(@"c:\temp\MoveLog.txt", copyError.Message + Environment.NewLine);
                }                    
            }  

            var endTime = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");
            File.AppendAllText(@"c:\temp\MoveLog.txt", "-----------------------------------------------------" + Environment.NewLine);
            File.AppendAllText(@"c:\temp\MoveLog.txt", "Move Complete " + endTime + Environment.NewLine);
            File.AppendAllText(@"c:\temp\MoveLog.txt", "-----------------------------------------------------" + Environment.NewLine);
            File.AppendAllText(@"c:\temp\MoveLog.txt", Environment.NewLine);

        }
        private static void Compare()
        {
            Console.Clear();
            Console.WriteLine("Please input location of .txt file list");
            var listPath = Console.ReadLine();
            Console.WriteLine("Input directory path for compare");
            var directoryPath = Console.ReadLine();
            
            var rougeDrawings = GetCargoFromList(listPath);
            var drawingFiles = GetCargoFromDirectory(directoryPath);

            var results = rougeDrawings.Except(drawingFiles);
                   
            ResultsWriter(results.ToList());
        }
        private static void ResultsWriter(List<DrawingCargo> results)
        {
            Console.WriteLine("Input directory and file name to save results in");
            var path = Console.ReadLine();
            using(var file = File.CreateText(path))
            {
                foreach (var result in results)
                {
                    file.Write(result.CargoID.ToString());
                    file.Write(',');
                    file.Write(result.CargoLocation.ToString());
                    file.Write(',');
                    file.Write(result.CargoType.ToString());
                    file.Write(',');
                    file.Write(result.CargoPath.ToString());
                    file.Write(',');
                }
            }
        }
        private static List<DrawingCargo> GetCargoFromDirectory(string directoryPath)
        {
            Console.Clear();
            Console.WriteLine("Finding Directories");
            var returnCargo = new List<DrawingCargo>();
            var path =  Directory.GetFiles(directoryPath, "*.??f", SearchOption.AllDirectories);
            Console.Clear();
            var counter = 0;
            Regex cargoIDStandard = new Regex(@"\d{2,3}-\d{2,3}-[A-E]-\d{3,4}");
            Regex typeExtractor = new Regex(@"\d{2,3}-\d{2,3}");
            
            foreach (var item in path)
            {
                var splitValue = cargoIDStandard.Match(item).ToString();
                var splitType = typeExtractor.Match(item).ToString();
                if(splitValue != null)
                {                    
                    var addValue = new DrawingCargo()
                    {
                        CargoID = splitValue,
                        CargoLocation = splitValue.Split('-').First(),
                        CargoType = splitType.Split('-').Last(),
                        CargoPath = item,
                        CargoName = item.Split(@"\").Last()
                    };
                    returnCargo.Add(addValue);
                    counter ++;
                    Console.WriteLine("Directory read progress");
                    Console.WriteLine(counter + " of " + path.Length);
                    Console.WriteLine(" ");
                    Console.WriteLine(addValue.CargoID);
                    Console.WriteLine(addValue.CargoLocation);
                    Console.WriteLine(addValue.CargoType);
                    Console.WriteLine(addValue.CargoName);
                    System.Threading.Thread.Sleep(10);
                    Console.Clear();
                    }
                    else
                    {
                        var errorFile = item.Split(@"\").Last();
                        File.AppendAllText(@"c:\temp\CompareLog.txt", "Error The Following File Is Missing ID " + errorFile);
                        counter++;
                    } 
            }
            return returnCargo;
        }         
        private static List<DrawingCargo> GetCargoFromList(string filePath)
        {
            var returnCargo = new List<DrawingCargo>();
            var id = File.ReadAllLines(filePath);
            var counter = 0;
            Regex cargoIDStandard = new Regex(@"\d{2,3}-\d{2,3}-[A-E]-\d{3,4}");
            Regex typeExtractor = new Regex(@"\d{2,3}-\d{2,3}");

            foreach (var item in id)
            {
                var splitValue = cargoIDStandard.Match(item).ToString();
                var splitType = typeExtractor.Match(item).ToString();
                var addValue = new DrawingCargo()
                {
                    CargoID = splitValue,
                    CargoLocation = splitValue.Split('-').First(),
                    CargoType = splitType.Split('-').Last(),
                    CargoPath = "Missing"
                };
                returnCargo.Add(addValue);
                counter ++;
                Console.WriteLine("File Read Progress");
                Console.WriteLine(counter + " of " + id.Length);
                Console.WriteLine(" ");
                Console.WriteLine(addValue.CargoID);
                Console.WriteLine(addValue.CargoLocation);
                Console.WriteLine(addValue.CargoType);
                System.Threading.Thread.Sleep(30);
                Console.Clear();
            
            }
            return returnCargo;
        }
               
    }
    
}
