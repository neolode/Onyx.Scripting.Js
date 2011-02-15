#region Using

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Reflection;
using Microsoft.JScript;

#endregion

namespace OnyxJS
{
    public class ScriptManager //: MarshalByRefObject, IScriptManager
    {
        public void CompileAndExecuteFile(string[] file, string[] args)
        {
            CodeDomProvider provider = new JScriptCodeProvider();

            var compilerparams =new CompilerParameters {GenerateInMemory = true, GenerateExecutable = true};
            //add to the list of assemblies referenced by the compiled script
            //see MockUp.cs
            compilerparams.ReferencedAssemblies.Add("OnyxJS.exe");
            CompilerResults results =
                provider.CompileAssemblyFromFile(compilerparams, file);
            if (results.Errors.HasErrors)
            {
                //ArrayList templist = new ArrayList();

                foreach (CompilerError error in results.Errors)
                {
                    Console.WriteLine(error.ErrorText + "\nin file:" + error.FileName + "(" + error.Line + "," +
                                      error.Column + ")");
                }
            }
            else
            {
                try
                {
                    results.CompiledAssembly.EntryPoint.Invoke(null, BindingFlags.Static, null, new object[] {args},
                                                               null);
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                    Console.WriteLine(x.StackTrace);
                }
            }
        }

    }
}