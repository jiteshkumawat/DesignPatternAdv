using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class RarCompression : ICompression
    {
        public void CompressFolder(string fileName)
        {
            Console.WriteLine("Compression logic implemented for RAR files.");
        }
    }
}
