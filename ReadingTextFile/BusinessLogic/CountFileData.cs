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

        public void CountLines()
        {
            Console.WriteLine("Line Count By Lambda Method:"+ _countLineData.GetCountByLambda(_fileLines));
            Console.WriteLine("Line Count By Query Method:" + _countLineData.GetCountByQuery(_fileLines));
        }

        public void CountWords()
        {
            Console.WriteLine("Word Count By Lambda Method:" + _countWordData.GetCountByLambda(_fileLines));
            Console.WriteLine("Word Count By Query Method:" + _countWordData.GetCountByQuery(_fileLines));
            
        }

        public void CountCharacters()
        {
            Console.WriteLine("Character Count By Lambda Method:" + _countCharacterData.GetCountByLambda(_fileLines));
            Console.WriteLine("Character Count By Query Method:" + _countCharacterData.GetCountByQuery(_fileLines));
        }
    }
}
