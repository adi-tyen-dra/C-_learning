using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOMethods
{
    internal class FilePropertiess
    {
        public FilePropertiess() 
        {
            String path = @"D:\DirectoryProperties\bye1.txt";

            //Creating a file
            FileStream fs = File.Create(path);
            Console.WriteLine("File has been created");

            //Deleting a file
            File.Delete(path);
            Console.WriteLine("File has been deleted");

            //Check if file exists
            Console.WriteLine(File.Exists(path) ? "File exists." : "File does not exist.");

            //Copy a file
            string path1 = @"D:\bye1.txt";
            string path2 = @"D:\bye2.txt";
            File.Copy(path1, path2);
            Console.WriteLine("File has been copied");

            //Move a file
            File.Move(path1, path2);
            Console.WriteLine("File has been moved");



        }   
    }
}
