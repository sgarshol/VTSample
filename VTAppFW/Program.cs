using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTLib;

namespace VTAppFW
{
    class Program
    {
        static void Main(string[] args)
        {
            var vtMaker = new VTMaker();

            var vt = vtMaker.GetVT();

            Console.WriteLine(vt.Item1);
            Console.WriteLine(vt.Item2);

            Console.ReadKey();
        }
    }
}
