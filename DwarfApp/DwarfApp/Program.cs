using System;

namespace DwarfApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dwarf dwarf = new Dwarf();
            dwarf.SayHello(dwarf.Name);

            Dwarfs dwarfs = new Dwarfs();
            dwarfs.SayHello1(dwarfs.Name1, dwarfs.Name2);
        }
    }
}
