using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTextFile.Classes
{
    internal interface ICountFileData
    {
        int GetCountByQuery(List<string> FileLines);
        int GetCountByLambda(List<string> FileLines);
    }
}