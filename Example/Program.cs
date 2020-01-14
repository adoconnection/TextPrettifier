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

            Console.WriteLine(prettifier.PrettifyForWeb(@"
                A long time ago, in a galaxy far,far away...
                It is a period of civil war. Rebel
                spaceships, striking from a hidden
                base, have won their first victory
                against the evil Galactic Empire.

                Price: 128 credits
Perpetuum Mobile — Myth
                Going on a bus"));

            Console.ReadKey();
        }
    }
}
