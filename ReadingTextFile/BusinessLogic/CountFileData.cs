using ReadingTextFile.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTextFile.BusinessLogic
{
    public class CountFileData
    {
        private readonly ICountFileData _countLineData;
        private readonly ICountFileData _countWordData;
        private readonly ICountFileData _countCharacterData;
        private readonly List<string> _fileLines;
        public CountFileData(List<string> fileLines)
        {
            _fileLines = fileLines;
            _countLineData = new CountLines();
            _countWordData = new CountWords();
            _countCharacterData = new CountCharacters();
        }

        /* These methods should not be void. You should never print anything on screen from your class unless it is the starting point i.e. main method*/

        public int CountLinesByLambda()
        {
            return _countLineData.GetCountByLambda(_fileLines);
        }

        public int CountLinesByQuery()
        {
            return _countLineData.GetCountByQuery(_fileLines);
        }


        public int CountWordsByLambda()
        {
            return _countWordData.GetCountByLambda(_fileLines);
        }

        public int CountWordsByQuery()
        {
            return _countWordData.GetCountByQuery(_fileLines);
        }

        public int CountCharactersByLambda()
        {
            return _countCharacterData.GetCountByLambda(_fileLines);
        }

        public int CountCharactersByQuery()
        {
            return _countCharacterData.GetCountByQuery(_fileLines);
        }
    }
}
