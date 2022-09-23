using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


    namespace ReadingTextFile
    {
        internal class Program
        {
        static readonly string textFile = @"C:\Users\swapnil.siddheshwar\Documents\C# Tasks\sample.txt";
        
        static void Main(string[] args)
            {
                var fileLines = File.ReadAllLines(textFile).ToList();
                int lineCount = 0;
                int wordCount = 0;
                int charCount = 0;


            lineCount = File.ReadAllLines(textFile).Select(lines => lines).Count();
            wordCount = File.ReadAllLines(textFile).SelectMany(lines => lines.Split(' ')).Count();
            charCount = (from line in fileLines
                        from word in line.Split(' ')
                        from ch in word
                        where ch != ' '
                        select ch).Count();
            
            Console.WriteLine("Total Lines:" + lineCount);
            Console.WriteLine("Total Words:" + wordCount);
            Console.WriteLine("Total Characters:" + charCount);
            Console.ReadKey();
        }
    }
}
