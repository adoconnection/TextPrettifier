using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextPrettifierLib;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {

            TextPrettifier prettifier = new TextPrettifier();

            Console.WriteLine(prettifier.PrettifyForWeb(@"here is the title"));

            Console.ReadKey();
        }
    }
}
