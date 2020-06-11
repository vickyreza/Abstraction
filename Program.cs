using System;
//using abstraction.AbstractClass;
using abstraction.Interface;

namespace abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Organtubuh organtubuh;

            organtubuh = new Tangan();
            organtubuh.Berfungsi();

            organtubuh = new Kaki();
            organtubuh.Berfungsi();*/
            
            IOrgantubuh organtubuh;

            organtubuh = new Tangan();
            organtubuh.Berfungsi();

            organtubuh = new Kaki();
            organtubuh.Berfungsi();


        }
    }
}
