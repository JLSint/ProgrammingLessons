using System;
using System.Collections.Generic;
using System.Text;

namespace DwarfApp
{
    class Dwarfs
    {
        public string Name1 = "Dwalina";
        public string Name2 = "Fili";

        public void SayHello1(string x, string y)
        {
            Console.WriteLine($"\nHello, my name is {x}!");
            Console.WriteLine($"\nHello, my name is {y}!");
        }
    }
}
