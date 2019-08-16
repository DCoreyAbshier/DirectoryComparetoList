using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DrawingConsolidationProject
{
    class GetDrawingList
    {

        public static List<Drawing> FromDirectory(string directoryPath)
        {
            Console.Clear();
            Console.WriteLine("Finding Directories");
            var returnDrawing = new List<Drawing>();
            var path = Directory.GetFiles(directoryPath, "*.??f", SearchOption.AllDirectories);
            Console.Clear();
            var counter = 0;
            Regex drawingIDStandard = new Regex(@"\d{1,3}-\d{1,3}-[A-Ea-e]-\d{1,4}");
            Regex drawingIDPipline = new Regex(@"\d{3}-\d{1,3}");
            Regex typeExtractor = new Regex(@"\d{1,3}-\d{1,3}");
            Regex sizeExtractor = new Regex(@"\d{1,3}-\d{1,3}-[A-Ea-e]");

            foreach (var item in path)
            {
                var splitValue = drawingIDStandard.Match(item).ToString();
                var splitType = typeExtractor.Match(item).ToString();
                var splitSize = sizeExtractor.Match(item).ToString();

                if (string.IsNullOrEmpty(splitValue) == false)
                {
                    var addValue = new Drawing()
                    {
                        drawingID = splitValue,
                        drawingLocation = splitValue.Split('-').First(),
                        drawingType = splitType.Split('-').Last(),
                        drawingPath = item,
                        drawingName = item.Split(@"\").Last(),
                        drawingSize = splitSize.Split('-').Last()
                    };
                    returnDrawing.Add(addValue);
                    counter++;
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
                else if (string.IsNullOrEmpty(splitValue = drawingIDPipline.Match(item).ToString()) == false)
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
                    counter++;
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
                    var exceptiondestination = Path.Combine(@"\\sscowbfs03\public\toms\cadd\Rendition\Exception\" + errorFile);
                    File.AppendAllText(@"\\sscowbfs03\public\toms\cadd\Rendition\Exception\CompareErrors.txt", "The Following File Is Missing ID Due to Improper Nameing " + errorFile + Environment.NewLine);
                    File.Copy(item, exceptiondestination, false);
                    counter++;
                }
            }
            return returnDrawing;
        }
        public static List<Drawing> FromList(string filePath)
        {
            var returnDrawing = new List<Drawing>();
            var id = File.ReadAllLines(filePath);
            var counter = 0;
            Regex drawingIDStandard = new Regex(@"\d{1,3}-\d{1,3}-[A-Ea-e]-\d{1,4}");
            Regex drawingIDPipline = new Regex(@"\d{3}-\d{1,3}");
            Regex typeExtractor = new Regex(@"\d{2,3}-\d{2,3}");
            Regex sizeExtractor = new Regex(@"\d{1,3}-\d{1,3}-[A-Ea-e]");

            foreach (var item in id)
            {
                var splitValue = drawingIDStandard.Match(item).ToString();
                var splitType = typeExtractor.Match(item).ToString();
                var splitSize = sizeExtractor.Match(item).ToString();

                if (string.IsNullOrEmpty(splitValue) == false)
                {
                    var addValue = new Drawing()
                    {
                        drawingID = splitValue,
                        drawingLocation = splitValue.Split('-').First(),
                        drawingType = splitType.Split('-').Last(),
                        drawingPath = "Missing",
                        drawingSize = splitSize.Split('-').Last()
                    };
                    returnDrawing.Add(addValue);
                    counter++;
                    Console.WriteLine("File Read Progress");
                    Console.WriteLine(counter + " of " + id.Length);
                    Console.WriteLine(" ");
                    Console.WriteLine(addValue.drawingID);
                    Console.WriteLine(addValue.drawingLocation);
                    Console.WriteLine(addValue.drawingType);
                    System.Threading.Thread.Sleep(30);
                    Console.Clear();
                }
                else if (string.IsNullOrEmpty(splitValue = drawingIDPipline.Match(item).ToString()) == false)
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
                    counter++;
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
                    File.AppendAllText(@"\\sscowbfs03\public\toms\cadd\Rendition\Exception\CompareErrors.txt", "The Following File Is Missing ID Due to Improper Nameing " + errorFile + Environment.NewLine);
                    counter++;
                }

            }
            return returnDrawing;
        }

    }
}
