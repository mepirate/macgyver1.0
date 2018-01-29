using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; /*This is the module used to read your computer stuffs*/
namespace macgyver
{
    class albumMaintenance
    {
        static void Main(string[] args)
        {
            string parseDir = "D:\\My Music\\";
            ParseDirectory(parseDir);
            Wait(15);
            Console.WriteLine("Terminated");
            
        }
        static void ParseDirectory(string dir)
        {
            /* 
             * Stack Overflow questino HERE: https://stackoverflow.com/questions/4254339/how-to-loop-through-all-the-files-in-a-directory-in-c-net
             * This guy is documented HERE https://msdn.microsoft.com/en-us/library/ms143316(v=vs.110).aspx 
             */
            string[] files = Directory.GetDirectories(dir);
            //string[] files = Directory.GetFiles(dir, "*.jpg", );
            
            foreach(string file in files)
            {
                //Console.WriteLine(file);
                string artistName = new DirectoryInfo(file).Name;
                getArtistInfo(artistName);
            }
        }

        static void Wait(Int64 nSeconds)
        {
            for (int i = 0; i < nSeconds; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Write(" . ");
            }
        }
        private static void getArtistInfo(string artist)
        {
            /**/
            Console.WriteLine("To Do: GET DATA FROM WEB FOR ARTIST [" + artist + "]");
        }
    }
}
