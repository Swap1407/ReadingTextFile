using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTextFile.Classes
{
    internal class LineCounnt : ICalcCount
    {
        public int Count { get; set; }

        public int GetCountByQS(List<string> fileLines)
        {
            Count = (from line in fileLines
                     select line).Count();
            return Count;
        }

        public int GetCountByMS(List<string> fileLines)
        {
            Count = fileLines.Select(lines => lines).Count();
            return Count;
        }

    }
}
