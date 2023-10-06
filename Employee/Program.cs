using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dolgozok> dolgozo = new List<Dolgozok>();
            
            using var sr = new StreamReader(
            @"../../../src/Employees.txt",
            Encoding.UTF8);
            






            Console.ReadKey();
        }
        public double KorAtlag()
        {
            double atlag = 0;


            return atlag;
        }
    }
}
