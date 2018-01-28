using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; /*This is the module used to read your computer stuffs*/
namespace macgyver
{
    class Program
    {
        static void Main(string[] args)
        {
            ParseDirectory();
            Wait(5);
            Console.WriteLine("Terminated");
        }
        static void ParseDirectory()
        {
            /* 
             * Stack Overflow questino HERE: https://stackoverflow.com/questions/4254339/how-to-loop-through-all-the-files-in-a-directory-in-c-net
             * This guy is documented HERE https://msdn.microsoft.com/en-us/library/ms143316(v=vs.110).aspx 
             */
            string[] files = Directory.GetFiles("C:\\temp\\","*", SearchOption.AllDirectories);
            foreach(string file in files)
            {
                Console.WriteLine(file);
            }
        }

        private static void Wait(Int64 nSeconds)
        {
            for (int i = 0; i < nSeconds; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Write(" . ");
            }
        }
    }
}
