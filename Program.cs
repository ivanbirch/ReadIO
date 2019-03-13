using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //method 1 - writing
            string[] lines = { "First 250", "Second 242", "Third 240" };

            File.WriteAllLines(@"..\..\highscores.txt", lines);
            /*
            //method 2 - writing
            Console.WriteLine("Please enter the file name:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file:");
            string input = Console.ReadLine();
            File.WriteAllText(@"..\..\" + fileName + ".txt" , input);
            */
            //method3 - writing
            using (StreamWriter file = new StreamWriter(@"..\..\myText.txt"))
            {
                foreach (string line in lines)
                {
                    if(line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
            using (StreamWriter file = new StreamWriter(@"..\..\myText2.txt"))
                foreach (string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }

                }
            using (StreamWriter file = new StreamWriter(@"..\..\myText2.txt", true))
            {
                file.WriteLine("Added a line");
            }
                /*
                //example 1 - Reading Text
                string text = System.IO.File.ReadAllText(@"..\..\assets.txt");
                Console.WriteLine("Text file contains the following text: ");
                Console.WriteLine("{0}", text);

                //Example 2 - Reading Text
                string[] lines = System.IO.File.ReadAllLines(@"..\..\assets.txt");

                Console.WriteLine("Contents of textfile:");
                foreach (string line in lines)
                {
                    Console.WriteLine("\t" + line);
                }
                */

                Console.ReadKey();
        }
    }
}
