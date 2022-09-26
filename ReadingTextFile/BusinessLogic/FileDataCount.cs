using ReadingTextFile.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTextFile.BusinessLogic
{
    public class FileDataCount
    {
        private readonly ICountFileData _countLineData;
        private readonly ICountFileData _countWordData;
        private readonly List<string> _fileLines;
        public FileDataCount(List<string> fileLines)
        {
            _fileLines = fileLines;
            _countLineData = new CountLines();
            _countWordData = new CountCharacters();
        }

        public int CountLines()
        {
            return _countLineData.GetCountByLambda(_fileLines);
        }

        public int CountWords()
        {
            return _countWordData.GetCountByLambda(_fileLines);
        }
    }
}
