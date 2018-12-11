using System;
using System.IO;

namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            var watcher = new FileSystemWatcher();
            watcher.Path = @"C:\TMP";
            watcher.EnableRaisingEvents = true;

            watcher.Created += FileCreated;
            watcher.Deleted += FileDelete;
            watcher.Renamed += FileRename;

            Console.ReadKey();





            //try
            //{

            //}
            //catch (Exception ex)
            //{

            //}











        }

        private static void FileRename(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File {e.Name} was renamed");
        }

        private static void FileDelete(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} was removed");
        }

        private static void FileCreated(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.Name} was created");
        }
    }
}
