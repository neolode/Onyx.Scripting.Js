using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnyxJS.OnyxCore
{
    public class console
    {
        public void write(object arg)
        {
            System.Console.Write(arg);
        }

        public void write(string format, object arg0)
        {
            System.Console.Write(format,arg0);
        }

        public void writel(object arg)
        {
            System.Console.WriteLine(arg);
        }

        public void writel(string format, object arg0)
        {
            System.Console.WriteLine(format, arg0);
        }

        public void waitKey()
        {
            this.writel("Press any key to continue...");
            System.Console.ReadKey(true);  
        }

    }
}
