using System;
using System.Collections.Generic;
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

            string entry_path = entry_point_file.Substring(0, entry_point_file.Length - file_name.Length);

            if (File.Exists(entry_path + "include.txt"))
            {
                TextReader tx = new StreamReader(entry_path + "include.txt");
                String buff;
                bool loop = true;
                while (loop)
                {
                    buff = tx.ReadLine();
                    if (buff == null) 
                    {
                        loop = false;
                        continue;
                    }
                    if (buff.StartsWith("//")) continue;
                    if (!File.Exists(buff)) continue;
                    files.Add(Path.GetFullPath(buff));
                }
            }

            //Directory.CreateDirectory(entry_path + "build");

            Console.WriteLine("entry  :" + entry_point_file);
            Console.WriteLine("folder :" + entry_path);

            return files.ToArray();
        }

    }
}
