using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTextFile.Classes
{
    internal class CountLines : ICountFileData
    {
        public int Count { get; set; }

        public int GetCountByQuery(List<string> fileLines)
        {
            return (from line in fileLines
                     select line).Count();
        }

        public int GetCountByLambda(List<string> fileLines)
        {
            return fileLines.Select(lines => lines).Count();
        }

    }
}
