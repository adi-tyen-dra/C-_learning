using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOMethods
{
    internal class DirectoryProperties
    {
        String path = @"D:\DirectoryProperties";
        public DirectoryProperties()
        {
            // If directory does not exist, create it.  
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            // Create sub
            String SubPath = path + "\\hi";
            if (!Directory.Exists(SubPath))
            {
                Directory.CreateDirectory(SubPath);
            }

            //Delete a folder
            if (Directory.Exists(SubPath))
            {
                Directory.Delete(SubPath);
            }

            //Moving a folder
            string sourceDirName = @"D:\DirectoryProperties";
            string destDirName = @"D:\API";
            try
            {
                Directory.Move(sourceDirName, destDirName);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            //Get and Set Directory Creation Time
            string fileName = @"D:\DirectoryProperties\hi";
            File.SetCreationTime(fileName, DateTime.Now);
            DateTime datetime = File.GetCreationTime(fileName);
            Console.WriteLine("File created at: {0}", datetime.ToString());

            // Get and set file last write time  
            fileName = @"D:\DirectoryProperties\hi";
            File.SetLastWriteTime(fileName, DateTime.Now);
            datetime = File.GetLastWriteTime(fileName);
            Console.WriteLine("File last write time: {0}", datetime.ToString());

            
            // Get a list of all subdirectories  
            var dirs = from dir in Directory.EnumerateDirectories(path) select dir;
            Console.WriteLine("Subdirectories: {0}", dirs.Count<string>().ToString());
            Console.WriteLine("List of Subdirectories");
            foreach (var dir in dirs)
            {
                Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
            }

            //Enumerate files
            var files = from file in Directory.EnumerateFiles(path)
                        select file;
            Console.WriteLine("Files: {0}", files.Count<string>().ToString());
            Console.WriteLine("List of Files");
            foreach (var file in files)
            {
                Console.WriteLine("{0}", file);
            }

            //Set current directory
            Directory.SetCurrentDirectory(path);
            Console.WriteLine(Directory.GetCurrentDirectory());

            //Get subdirectories
            string[] subdirectoryEntries = Directory.GetDirectories(path);
            foreach(String directory in subdirectoryEntries) 
            {
                Console.WriteLine(directory);
            }

            //Get files in a directory
            string[] filea = Directory.GetFiles(path);
            foreach (string file in filea) ;
            Console.WriteLine(filea);

            //Get root directory
            Console.WriteLine(Directory.GetDirectoryRoot(path));

        }
    }
}
