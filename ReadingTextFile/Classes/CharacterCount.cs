using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTextFile.Classes
{
    internal class CharacterCount : ICalcCount
    {
        public int Count { get; set; }

        public int GetCountByQS(List<string> fileLines)
        {
            Count = (from line in fileLines
                     from word in line.Split(' ')
                     from ch in word
                     where ch != ' '
                     select ch).Count();
            return Count;
        }

        public int GetCountByMS(List<string> fileLines)
        {
            Count = fileLines.SelectMany(lines => lines.Split(' ')).ToList().SelectMany(x => x).Count();
            return Count;
        }
    }
}
