#region Using

using System;

#endregion

namespace OnyxJS
{
    public class MockUp
    {
        public static void test()
        {
            Console.WriteLine("MockUp procedure to test interop ran succesfull");
        }

        public static void printl(string s)
        {
            Console.WriteLine(s);
        }

        public static void print(string s)
        {
            Console.Write(s);
        }

        public static void wait_key()
        {
            Console.ReadKey(true);
        }
    }
}