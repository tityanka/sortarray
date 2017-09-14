using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("lorem.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        Char delimiter = ' ';
                        char[] charsToTrim = { '.', ',' };
                        String[] substrings = line.Split(delimiter);
                        foreach (var substring in substrings)
                        {
                            substring.TrimEnd(charsToTrim);
                            Console.WriteLine(substring);
                            //Console.WriteLine(substring.GetType());

                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
