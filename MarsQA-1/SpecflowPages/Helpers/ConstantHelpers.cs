using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://localhost:5000";

        //Path
        public static string path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        //ScreenshotPath
        public static string ScreenshotPath = "";

        //ExtentReportsPath
        public static string ReportsPath = "";

        //ReportXML Path
        public static string ReportXMLPath = "";
    }
}