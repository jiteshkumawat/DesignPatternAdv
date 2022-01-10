using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ReportGenerator
    {
        private ICompression compression;

        public ReportGenerator(ICompression compression)
        {
            this.compression = compression;
        }

        public void GenerateReport(string fileName)
        {
            Console.WriteLine("Generating Report.");
            Console.WriteLine("Compressing File.");

            this.compression.CompressFolder(fileName);

            Console.WriteLine("Report saved with file " + fileName);
        }
    }
}
