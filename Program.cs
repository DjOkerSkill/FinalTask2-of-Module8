using System;
using System.IO;

namespace ConsoleApp7
{
    internal class Program
    {

        public static long DirSize(DirectoryInfo di)
        {
            long size = 0;

            FileInfo[] fl = di.GetFiles();

            foreach (FileInfo fi in fl)
            {
                size += fi.Length;
            }

            DirectoryInfo[] dr = di.GetDirectories();

            foreach (DirectoryInfo df in dr)g
            {
                size += DirSize(df);
            }
            return size;
        }

        static void Main(string[] args)
        {
            try
            {
                string URLdirectory = "C:/C#.NET учеба";

                DirectoryInfo directoryInfo = new DirectoryInfo(URLdirectory);

                long ResultSize = DirSize(directoryInfo);

                Console.WriteLine($"Размер папки {URLdirectory} составляет: {ResultSize} байт");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
