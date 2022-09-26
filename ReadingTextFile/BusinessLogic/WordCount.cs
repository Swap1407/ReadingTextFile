using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTextFile.Classes
{
    internal class WordCount : ICalcCount
    {
        public int Count { get; set; }

        public int GetCountByQS(List<string> fileLines)
        {
            Count = (from line in fileLines
                     from word in line.Split(' ')
                     select word).Count();
            return Count;
        }

        public int GetCountByMS(List<string> fileLines)
        {
            Count = fileLines.SelectMany(lines => lines.Split(' ')).Count();
            return Count;
        }
    }
}
