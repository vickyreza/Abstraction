using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction.Interface
{
    public class Tangan : IOrgantubuh
    {
        public void Berfungsi()
        {
            Console.WriteLine("Tangan berfungsi untuk menyentuh sesuatu");
            Console.WriteLine("Tangan juga berfungsi untuk makan\n");
        }
    }
}
