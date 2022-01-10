using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface ICompression
    {
        void CompressFolder(string fileName);
    }
}
