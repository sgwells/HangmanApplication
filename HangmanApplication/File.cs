﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HangmanApplication
{
    class File
    {
        public string[] lines;

        public void ReadFile()
        {
            try
            {
                lines = System.IO.File.ReadAllLines(@" C:\Users\Scott\Desktop\MSNET\WriteLines.txt");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void WriteToFile()
        {
            try
            {
                // Example #1: Write an array of strings to a file.
                // Create a string array that consists of three lines.
                string[] lines = { "First line", "Second line", "Third line" };
                // WriteAllLines creates a file, writes a collection of strings to the file,
                // and then closes the file.  You do NOT need to call Flush() or Close().
                System.IO.File.WriteAllLines(@" C:\Users\Scott\Desktop\MSNET\WriteLines.txt", lines);
               
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
