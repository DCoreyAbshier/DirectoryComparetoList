using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DrawingConsolidationProject
{
    class MoveFileLogger
    {

        public static void EndLog(string endTime)
        {
            File.AppendAllText(@"c:\temp\MoveLog.txt",
                "-----------------------------------------------------" + Environment.NewLine);
            File.AppendAllText(@"c:\temp\MoveLog.txt", "Move Complete " + endTime + Environment.NewLine);
            File.AppendAllText(@"c:\temp\MoveLog.txt",
                "-----------------------------------------------------" + Environment.NewLine);
            File.AppendAllText(@"c:\temp\MoveLog.txt", Environment.NewLine);
        }

        public static void StartLog(string startTime)
        {
            File.AppendAllText(@"c:\temp\MoveLog.txt",
                "-----------------------------------------------------" + Environment.NewLine);
            File.AppendAllText(@"c:\temp\MoveLog.txt", "Move initialized " + startTime + Environment.NewLine);
            File.AppendAllText(@"c:\temp\MoveLog.txt",
                "-----------------------------------------------------" + Environment.NewLine);
        }

    }
}
