using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ZipCompression : ICompression
    {
        public void CompressFolder(string fileName)
        {
            Console.WriteLine("Compression logic implemented for ZIP files.");
        }
    }
}
