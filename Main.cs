#region Using

using System;
using System.IO;

#endregion

namespace OnyxJS
{
    internal class Test
    {
        public static void Main(string[] args)
        {
            var fileName = string.Empty;
            if (args.Length < 1)
            {
                Console.WriteLine("You haven't provided a script file");
                return;
            }

            fileName = args[0];
            if (!File.Exists(fileName))
            {
                Console.WriteLine("FileDoesnotExist:" + args[0]);
                return;
            }

            //Create new argument array removing the file name
            var newargs = new String[args.Length - 1];
            Array.Copy(args, 1, newargs, 0, args.Length - 1);

            var sc = new ScriptManager();
            sc.CompileAndExecuteFile(ScriptUtils.BuildFilesList(fileName), newargs);
            Console.ReadKey();
        }
    }
}