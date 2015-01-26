using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Paths
{
    public static class Storage
    {
        public static void SavePathToATextFile(string path, string fileLocation, string fileName)
        {
            System.IO.File.WriteAllText(@"D:\Documents\OOP\02_StaticMembersAndNamespaces\Homework\StaticMembersAndNamespaces\03_Paths\TxtStorageFiles\WriteText.txt", path);
        }


    }
}
