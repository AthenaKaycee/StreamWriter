using System;
using System.IO;

namespace Apppendtext
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\kcbow\\OneDrive\\Desktop\\oscar.txt";
            string[] poem = new string[]
            {
             "\tIn Debtors' Yard the stones are hard",
             "\tAnd the dripping wall is high ",
            
            
            };
            string attrib = "\r\n\tThe Ballad of Reading Gaol";
            attrib += "(Oscsr wilde 1898)";
            attrib += "I am a cowboy";

            //add statement to test if a file already exist of the specified path and filename
            if (File.Exists(path)) 
            {
                File.AppendAllText(path, attrib);
                Console.WriteLine("Appended To File: " + path);
            }
            else
            {
                try
                {
                    File.WriteAllLines(path, poem);
                    Console.WriteLine("file written: " + path);
                }catch(Exception error) 
            {
                Console.WriteLine(error.Message);
            }
            
            }
        }  
    }
}
