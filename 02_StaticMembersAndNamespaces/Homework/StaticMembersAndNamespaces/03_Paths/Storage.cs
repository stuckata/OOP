using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Paths
{
    public static class Storage
    {
        public static void SavePointsPathToTxtFile(string path, string fileLocation, string fileName)
        {
            System.IO.File.WriteAllText(@"" + fileLocation + "\\" + fileName + ".txt", path);
        }

        public static void ReadPointsPathFromTxtFile(string fileLocation, string fileName)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileLocation + "\\" + fileName + ".txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
