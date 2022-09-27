using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ReadingTextFile.Classes;
using ReadingTextFile.BusinessLogic;

namespace ReadingTextFile
    {
        internal class Program
        {
        const string textFile = @"C:\Users\swapnil.siddheshwar\Documents\C# Tasks\sample.txt";
        static void Main(string[] args)
            {
            try
            {
                var fileLines = File.ReadAllLines(textFile).ToList();

                var countFileData = new CountFileData(fileLines);
                countFileData.CountLines();
                countFileData.CountWords();
                countFileData.CountCharacters();
            }
            catch (Exception ex)
            {
                Console.WriteLine("File Not Found\n"+ex);
            }

            Console.ReadKey();
        }
    }
}
