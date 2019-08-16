using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

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
            ConsoleSettings.EnableQuickEditMode();
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
            Creator.CreateDirectory();
            var pathToScannedDrawing = Console.ReadLine();
            var pendingScannedDrawings = GetDrawingList.FromDirectory(pathToScannedDrawing);
            var startTime = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");
            MoveFileLogger.StartLog(startTime);

            foreach(var drawing in pendingScannedDrawings)
            {
                var exceptiondestination = Path.Combine(@"\\sscowbfs03\public\toms\cadd\Rendition\Exception\" + drawing.drawingName);
                var directory = " ";

                if (drawing.drawingLocation=="005")
                {
                    directory = GeneralFacilityDictionary.GetDestination(drawing);
                }
                else
                {
                    directory = Dictionary.GetDestination(drawing);
                }

                if (directory == null)
                {
                    var errorFile = drawing.drawingName;
                    File.AppendAllText(@"\\sscowbfs03\public\toms\cadd\Rendition\Exception\MoveLog.txt", "The Following File Is Has no Destination: " + errorFile + Environment.NewLine);
                    File.Copy(drawing.drawingPath, exceptiondestination, false);
                }
                else
                {
                    CopyFiles(drawing, directory, exceptiondestination);
                }
                                    
            }  

            var endTime = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt");
            MoveFileLogger.EndLog(endTime);
        }

        private static void CopyFiles(Drawing drawing, string directory, string exceptiondestination)
        {
            
            var destination = Path.Combine(directory, drawing.drawingName);

            try
            {
                File.Copy(drawing.drawingPath, destination, false);
                var moveResults = drawing.drawingName + " moved successfully ";
                File.AppendAllText(@"\\sscowbfs03\public\toms\cadd\Rendition\Exception\MoveLog.txt",
                    moveResults + Environment.NewLine);
            }
            catch (IOException copyError)
            {
                File.AppendAllText(@"\\sscowbfs03\public\toms\cadd\Rendition\Exception\MoveLog.txt",
                    copyError.Message + Environment.NewLine);
                File.Copy(drawing.drawingPath, exceptiondestination, false);
            }
        }

        private static void Compare()
        {
            Console.Clear();
            Console.WriteLine("Please input location of .txt file list");
            var listPath = Console.ReadLine();
            Console.WriteLine("Input directory path for compare");
            var directoryPath = Console.ReadLine();
            
            var hardCopyDrawings = GetDrawingList.FromList(listPath);
            var drawingsInRendition = GetDrawingList.FromDirectory(directoryPath);

            var results = hardCopyDrawings.Except(drawingsInRendition);

            Output.ResultsWriter(results.ToList());
        }
    }
}

