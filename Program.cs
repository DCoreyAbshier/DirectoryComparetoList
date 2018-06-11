using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DrawingConsolidationProject
{
    class Drawing
    {        
        public string drawingPath {get;set;}
        public string drawingLocation {get;set;}
        public string drawingType {get;set;}
        public string drawingID {get;set;}
        public string drawingName {get;set;}
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
            var pathToScannedDrawing = Console.ReadLine();
            Console.WriteLine("Input directory path for destination");
            var scannedDrawingDestination = Console.ReadLine();
            var pendingScannedDrawings = GetScannedDrawingsFromDirectory (pathToScannedDrawing);
            var startTime = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");
            File.AppendAllText(@"c:\temp\MoveLog.txt", "-----------------------------------------------------" + Environment.NewLine);
            File.AppendAllText(@"c:\temp\MoveLog.txt", "Move initialized " + startTime + Environment.NewLine );
            File.AppendAllText(@"c:\temp\MoveLog.txt", "-----------------------------------------------------" + Environment.NewLine);

            foreach(var drawing in pendingScannedDrawings)
            {
                
                var destination = Path.Combine(scannedDrawingDestination, drawing.drawingName);
                try
                {
                    File.Copy (drawing.drawingPath, destination, false);
                    var moveResults = drawing.drawingName + " moved successfully ";
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
            
            var hardCopyDrawings = GetDrawingFromList(listPath);
            var drawingsInRendition = GetScannedDrawingsFromDirectory(directoryPath);

            var results = hardCopyDrawings.Except(drawingsInRendition);
                   
            ResultsWriter(results.ToList());
        }
        private static void ResultsWriter(List<Drawing> results)
        {
            Console.WriteLine("Input directory and file name to save results in");
            var path = Console.ReadLine();
            using(var file = File.CreateText(path))
            {
                foreach (var result in results)
                {
                    file.Write(result.drawingID.ToString());
                    file.Write(',');
                    file.Write(result.drawingLocation.ToString());
                    file.Write(',');
                    file.Write(result.drawingType.ToString());
                    file.Write(',');
                    file.Write(result.drawingPath.ToString());
                    file.Write(',' + Environment.NewLine);
                }
            }
        }
        private static List<Drawing> GetScannedDrawingsFromDirectory(string directoryPath)
        {
            Console.Clear();
            Console.WriteLine("Finding Directories");
            var returnDrawing = new List<Drawing>();
            var path =  Directory.GetFiles(directoryPath, "*.??f", SearchOption.AllDirectories);
            Console.Clear();
            var counter = 0;
            Regex drawingIDStandard = new Regex(@"\d{1,3}-\d{1,3}-[A-E]-\d{1,4}");
            Regex drawingIDPipline = new Regex(@"\d{3}-\d{1,3}");
            Regex typeExtractor = new Regex(@"\d{1,3}-\d{1,3}");
            
            foreach (var item in path)
            {
                var splitValue = drawingIDStandard.Match(item).ToString();
                var splitType = typeExtractor.Match(item).ToString();
                if(string.IsNullOrEmpty(splitValue) == false)
                {                    
                    var addValue = new Drawing()
                    {
                        drawingID = splitValue,
                        drawingLocation = splitValue.Split('-').First(),
                        drawingType = splitType.Split('-').Last(),
                        drawingPath = item,
                        drawingName = item.Split(@"\").Last()
                    };
                    returnDrawing.Add(addValue);
                    counter ++;
                    Console.WriteLine("Directory read progress");
                    Console.WriteLine(counter + " of " + path.Length);
                    Console.WriteLine(" ");
                    Console.WriteLine(addValue.drawingID);
                    Console.WriteLine(addValue.drawingLocation);
                    Console.WriteLine(addValue.drawingType);
                    Console.WriteLine(addValue.drawingName);
                    System.Threading.Thread.Sleep(10);
                    Console.Clear();
                }
                else if(string.IsNullOrEmpty(splitValue = drawingIDPipline.Match(item).ToString()) == false)
                {
                    splitValue = drawingIDPipline.Match(item).ToString();
                    var addValue = new Drawing()
                    {
                        drawingID = splitValue,
                        drawingLocation = splitValue.Split('-').First(),
                        drawingType = "PipeLine",
                        drawingPath = item,
                        drawingName = item.Split(@"\").Last()
                    };
                    returnDrawing.Add(addValue);
                    counter ++;
                    Console.WriteLine("Directory read progress");
                    Console.WriteLine(counter + " of " + path.Length);
                    Console.WriteLine(" ");
                    Console.WriteLine(addValue.drawingID);
                    Console.WriteLine(addValue.drawingLocation);
                    Console.WriteLine(addValue.drawingType);
                    Console.WriteLine(addValue.drawingName);
                    System.Threading.Thread.Sleep(10);
                    Console.Clear();
                }
                else
                {
                    var errorFile = item.Split(@"\").Last();
                    File.AppendAllText(@"c:\temp\CompareLog.txt", "The Following File Is Missing ID Due to Improper Nameing " + errorFile + Environment.NewLine);
                    counter++;
                } 
            }
            return returnDrawing;
        }         
        private static List<Drawing>GetDrawingFromList(string filePath)
        {
            var returnDrawing = new List<Drawing>();
            var id = File.ReadAllLines(filePath);
            var counter = 0;
            Regex drawingIDStandard = new Regex(@"\d{1,3}-\d{1,3}-[A-E]-\d{1,4}");
            Regex drawingIDPipline = new Regex(@"\d{3}-\d{1,3}");
            Regex typeExtractor = new Regex(@"\d{2,3}-\d{2,3}");

            foreach (var item in id)
            {
                var splitValue = drawingIDStandard.Match(item).ToString();
                var splitType = typeExtractor.Match(item).ToString();
                if(string.IsNullOrEmpty(splitValue) == false)
                {  
                    var addValue = new Drawing()
                    {
                        drawingID = splitValue,
                        drawingLocation = splitValue.Split('-').First(),
                        drawingType = splitType.Split('-').Last(),
                        drawingPath = "Missing"
                    };
                    returnDrawing.Add(addValue);
                    counter ++;
                    Console.WriteLine("File Read Progress");
                    Console.WriteLine(counter + " of " + id.Length);
                    Console.WriteLine(" ");
                    Console.WriteLine(addValue.drawingID);
                    Console.WriteLine(addValue.drawingLocation);
                    Console.WriteLine(addValue.drawingType);
                    System.Threading.Thread.Sleep(30);
                    Console.Clear();
                }
                else if(string.IsNullOrEmpty(splitValue = drawingIDPipline.Match(item).ToString()) == false)
                {
                    splitValue = drawingIDPipline.Match(item).ToString();
                    var addValue = new Drawing()
                    {
                        drawingID = splitValue,
                        drawingLocation = splitValue.Split('-').First(),
                        drawingType = "PipeLine",
                        drawingPath = "Missing"
                    };
                    returnDrawing.Add(addValue);
                    counter ++;
                    Console.WriteLine("Directory read progress");
                    Console.WriteLine(counter + " of " + id.Length);
                    Console.WriteLine(" ");
                    Console.WriteLine(addValue.drawingID);
                    Console.WriteLine(addValue.drawingLocation);
                    Console.WriteLine(addValue.drawingType);
                    System.Threading.Thread.Sleep(10);
                    Console.Clear();
                }
                else
                {
                    var errorFile = item;
                    File.AppendAllText(@"c:\temp\CompareLog.txt", "The Following File Is Missing ID Due to Improper Nameing " + errorFile + Environment.NewLine);
                    counter++;
                } 
            
            }
            return returnDrawing;
        }
        private string Throwaway()
        {
            var dictionary = new Dictionary<throwaway, string>();

            dictionary.Add(new throwaway("tyr", "grt"),@"c:\users\abshier_c\temp");

            var type = "grt";
            var location = "tyr";

            var founditem = dictionary.FirstOrDefault(x => x.Key.type == type && x.Key.location == location);

            return founditem.Value;
        }

         public class throwaway
         {
             public throwaway(string location, string type)
             {
                 this.location = location;
                 this.type =type;
             }
             public string location{get; set;}
             public string type{get; set;}

         }      
    }
    
}

