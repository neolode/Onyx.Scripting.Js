using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OnyxJS
{
    class ScriptUtils
    {
        public static string[] BuildFilesList(String entry_point_file)
        {
            entry_point_file = Path.GetFullPath(entry_point_file);
            string file_name = Path.GetFileName(entry_point_file);
            List<string> files = new List<string>();
            files.Add(entry_point_file);

            string entry_path = entry_point_file.Substring(0, entry_point_file.Length-file_name.Length);

            Directory.CreateDirectory(entry_path + "build");

            Console.WriteLine("entry  :" + entry_point_file);
            Console.WriteLine("folder :" + entry_path);

            return files.ToArray();
        }

    }
}
