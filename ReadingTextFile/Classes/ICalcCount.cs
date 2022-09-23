﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTextFile.Classes
{
    internal interface ICalcCount
    {
        int GetCountByQS(List<string> sQS);
        int GetCountByMS(List<string> sMS);
    }
}
