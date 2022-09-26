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

        //why internal and not public
        //=> to make class accessible only from this assembly
        internal class Program
        {

        //why we have used readonly here and not const
        //=>const can'n be used with static keyword and if static is not used we have to create
        //obj of program class
        //=> @ used here to ignore escape characters and line breaks
        static readonly string textFile = @"C:\Users\swapnil.siddheshwar\Documents\C# Tasks\sample.txt";
        

        // you should not write your whole logic in Main. You should use OOPs. Dividing your functionality into classes which contains related methods.
        static void Main(string[] args)
            {
            if (File.Exists(textFile))
            {
                var fileLines = File.ReadAllLines(textFile).ToList();


                var fileDataCount = new FileDataCount(fileLines);
                var lineCount = fileDataCount.CountLines();
                var wordCount = fileDataCount.CountWords();

               /* Console.WriteLine("   Reading Text File using LINQ ");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("\n  Total Lines by Query Syntax:" + lineCountQS);
                Console.WriteLine("  Total Lines by Method Syntax:" + lineCountMS + "\n");

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("\n  Total Words by Query Syntax:" + wordCountQS);
                Console.WriteLine("  Total Words by Method Syntax:" + wordCountMS + "\n");

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("\n  Total Characters by Query Syntax:" + charCountQS);
                Console.WriteLine("  Total Characters by Method Syntax:" + charCountMS + "\n");
                Console.WriteLine("----------------------------------------------------");*/

            }
            else
            {
                Console.WriteLine("File Not Found...");
            }

            Console.ReadKey();
        }
    }
}
