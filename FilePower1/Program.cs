using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace FilePower1
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
            Queue<string> queue = new Queue<string>();

            Console.WriteLine("Insert a name to the file. Press ENTER to stop.");
            string input;
            while ((input = Console.ReadLine())!= "")
            {
                queue.Enqueue(input);
            }

            StreamWriter writer = new StreamWriter(fileName);
            while (queue.Count > 0)
            {
                string line = queue.Dequeue();
                writer.WriteLine(line);
            }
            writer.Close();
            Console.WriteLine("Saved successfully!.");
        }  
    }
}
