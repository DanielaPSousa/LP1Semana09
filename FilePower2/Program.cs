using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace FilePower2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please provide a file name.");
                return;
            }

            string fileName = args[0];
            Console.WriteLine("Insert a name to the file. Press ENTER to stop.");

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                string input;
                while ((input = Console.ReadLine())!= "")
                {
                    writer.WriteLine(input);
                }
            }
            Console.WriteLine("Saved successfully!.");
        }
    }
}
