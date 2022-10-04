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
                var lineCountByLambda =  countFileData.CountLinesByLambda();
                var wordCountByLambda =  countFileData.CountWordsByLambda();
                var charactersCountByLambda = countFileData.CountCharactersByLambda();
                var lineCountByQuery = countFileData.CountLinesByQuery();
                var wordCountByQuery = countFileData.CountWordsByQuery();
                var charactersCountByQuery = countFileData.CountCharactersByQuery();

                Console.WriteLine("Total number of lines by Lambda method :" + lineCountByLambda + " by Query method :" + lineCountByQuery);
                Console.WriteLine("Total number of words by Lambda method :" + wordCountByLambda + " by Query method :" + wordCountByQuery);
                Console.WriteLine("Total number of characterss by Lambda method :" + charactersCountByLambda + " by Query method :" + charactersCountByQuery);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
