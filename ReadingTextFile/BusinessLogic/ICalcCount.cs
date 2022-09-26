using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTextFile.Classes
{
    internal interface ICountFileData
    {
        int GetCountByQuery(List<string> sQS);
        int GetCountByLambda(List<string> sMS);
    }
}
