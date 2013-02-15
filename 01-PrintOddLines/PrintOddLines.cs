

using System;
using System.IO;
using System.Text;
namespace _01_PrintOddLines
{
    class PrintOddLines
    {
        //Just a comment ...
        static void Main()
        {
            StreamReader Gireader = new StreamReader(@"../../../folktale.txt");
            using (Gireader)
            {
                int number = 1;
                string Line = Gireader.ReadLine();
                while (Line != null)
                {
                    number++;
                    if (number % 2 != 0)
                    {
                        Console.WriteLine(Line);
                    }
                    Line = Gireader.ReadLine();
                }
            }
        }
    }
}

