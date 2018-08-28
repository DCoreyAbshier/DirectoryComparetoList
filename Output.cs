using System;
using System.Collections.Generic;
using System.IO;

namespace DrawingConsolidationProject
{
    class Output
    {
        public static void ResultsWriter(List<Drawing> results)
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
    }
}