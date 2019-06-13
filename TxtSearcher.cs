using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryName = null;
            string patternFileName = null;
            List<string> fileNames;
            string patternText = null;
            

            directoryName = Console.ReadLine();
            patternFileName = Console.ReadLine();
            patternText = Console.ReadLine();

            fileNames = Directory.GetFiles(@directoryName, patternFileName,SearchOption.AllDirectories).ToList();
          
            RegexOptions options = RegexOptions.IgnoreCase;
            Regex regex = new Regex(patternText, options);

            foreach (var element in fileNames)
            {
                //data.Add(File.ReadAllText(element, Encoding.Default));

                using (StreamReader sr = new StreamReader(element, Encoding.Default))
                {
                    //data.Add(sr.ReadToEnd());
                    //sr.ReadToEnd();
                    Console.WriteLine("File name: {0}, Match: {1}",element,regex.IsMatch(sr.ReadToEnd()));
                }

            }

            
            Console.ReadKey();

        }
    }
}
