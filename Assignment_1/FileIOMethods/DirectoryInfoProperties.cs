using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOMethods
{
    internal class DirectoryInfoProperties
    {
        String path = @"D:\DirectoryProperties";
        public DirectoryInfoProperties() 
        {
            DirectoryInfo Dinfo=new DirectoryInfo(path);
            //Create a directory with given path name
            Dinfo.Create();
            Dinfo.CreateSubdirectory(path);

            //Delete a directory and all its content
            Dinfo.Delete(true);

            //return an array of all subdirectories in the current directory
            DirectoryInfo[] directories=Dinfo.GetDirectories(path);

            //Retrives a file's extension
            String extension=Dinfo.Extension;

            //Return an array of files that represents a set of files in the given directory
            FileInfo[] fileinfo=Dinfo.GetFiles();

            //Moves a directory and all its content to the given destination
            Dinfo.MoveTo(path);

            //Returns the parent directory of this directory
            DirectoryInfo parent=Dinfo.Parent;

            //Gets the root portion of a path
            DirectoryInfo root=Dinfo.Root;
        }
    }
}
