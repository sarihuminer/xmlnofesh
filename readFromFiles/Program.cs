using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readFromFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            GoToFiles ob;
            if (args.Length == 0)
                ob = new GoToFiles();
            else
                ob = new GoToFiles(args[0]);


            ob.Save();

            List<string> olds = ob.GetFromFile();
            foreach (var item in olds)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
