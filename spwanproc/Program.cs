using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using murrayju.ProcessExtensions;

namespace spwanproc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Calc.exe");
            ProcessExtensions.StartProcessAsCurrentUser("calc.exe");
            Console.ReadKey();
        }
    }
}
