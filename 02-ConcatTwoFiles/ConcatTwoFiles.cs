using System;
using System.IO;
using System.Text;

namespace _02_ConcatTwoFiles
{
    class ConcatTwoFiles
    {
        static void Main()
        {
            StreamReader ReaderPart1 = new StreamReader(@"../../../part1.txt");
            StreamReader ReaderPart2 = new StreamReader(@"../../../part2.txt");
            using (ReaderPart1)
            {
                StreamWriter Writer = new StreamWriter(@"../../../part12.txt", true);
                using (Writer)
                {
                    string currentLine;
                    while ((currentLine = ReaderPart1.ReadLine()) != null)
                    {
                        Writer.WriteLine(currentLine);
                    }
                }
            }
            using (ReaderPart2)   //read and append(true) second file to first file
            {
                StreamWriter Writer = new StreamWriter(@"../../../part12.txt", true, Encoding.GetEncoding("utf-8"));
                using (Writer)
                {
                    string currentLine;
                    while ((currentLine = ReaderPart2.ReadLine()) != null)
                    {
                        Writer.WriteLine(currentLine);
                    }
                }
            }
            Console.WriteLine("\n Done! \n");
        }
    }
}

