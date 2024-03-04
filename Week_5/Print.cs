using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    internal class Print
    {
        public static void Write(string text)
        {
            Console.WriteLine(text);
        }

        public static void WriteToFile(string text)
        {
            string filePath = "output.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine($"Date:{DateTime.Now.ToShortDateString()} Time:{DateTime.Now.ToLongTimeString()}");
                    writer.WriteLine($"The number of people in the list is {text}");
                }
                Console.WriteLine($"Data written to file {filePath}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
        }
    }
}
