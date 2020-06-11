using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction.AbstractClass
{
    public class Tangan : Organtubuh
    {
        public override void Berfungsi()
        {
            Console.WriteLine("Tangan berfungsi untuk menyentuh sesuatu");
            Console.WriteLine("Tangan juga berfungsi untuk makan\n");
        }
    }
}
