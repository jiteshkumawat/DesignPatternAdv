using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ReportGenerator reportGenerator = new ReportGenerator(new ZipCompression());
            reportGenerator.GenerateReport("ZipFileresult");

            ReportGenerator reportGenerator1 = new ReportGenerator(new RarCompression());
            reportGenerator1.GenerateReport("RarFileResult");

            Console.Read();
        }
    }
}
