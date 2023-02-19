using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOMethods
{
    internal class FileInfoProperties
    {
        public FileInfoProperties() 
        {
            
            //String path = @"D:\DirectoryProperties";

            //Create new streamwriter that write in file
            FileInfo fileinfo = new FileInfo(@"D:\Text1.txt");
            StreamWriter sw = fileinfo.CreateText();
            sw.WriteLine("hello");
            Console.WriteLine("File has been created with text");
            sw.Close();

            //Delete existing file
            fileinfo.Delete();
            Console.WriteLine("File has been deleted");

            //Copy existing file to another
            string path1 = @"D:\Text1.txt";
            string path2 = @"D:\Text2.txt";
            FileInfo file = new FileInfo(path1);
            file.CopyTo(path2);

            //Move file
            file = new FileInfo(path1);
            file.MoveTo(path1);

            // Add text to a file
            file = new FileInfo(@"D:\NewText1.txt");
            sw = file.AppendText();
            sw.WriteLine("This");
            sw.WriteLine("is Extra");
            sw.WriteLine("Text");
            Console.WriteLine("File has been appended");
            sw.Close();

            //Reading a file
            StreamReader sr = file.OpenText();
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }

            //Other properties related to file
            file = new FileInfo(@"D:\NewText1.txt");
            Console.WriteLine("File name is {0} ", file.Name);
            Console.WriteLine("File creation time is {0} ", file.CreationTime.ToLongTimeString());
            Console.WriteLine("File Lastaccesstime is {0} ", file.LastAccessTime.ToLongDateString());
            Console.WriteLine("File length is {0} ", file.Length.ToString() + " Bytes");
            Console.WriteLine("File extension is {0} ", file.Extension);
            Console.WriteLine("File exist is: ", file.Exists);
            Console.WriteLine("File LastWriteTime is {0} ", file.LastWriteTime);

        }
    }
}
