using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTextFile.Classes
{
    internal class CountWords : ICountFileData
    {
        public int GetCountByQuery(List<string> fileLines)
        {
            return (from line in fileLines
                     from word in line.Split(' ')
                     select word).Count();
           
        }

        public int GetCountByLambda(List<string> fileLines)
        {
            return fileLines.SelectMany(lines => lines.Split(' ')).Count();
        }
    }
}
