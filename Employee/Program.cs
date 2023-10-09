using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dolgozok> dolgozo = new List<Dolgozok>();
            
            using var sr = new StreamReader(
            path: @"../../../src/Employees.txt",
            encoding: System.Text.Encoding.UTF8);
            _ = sr.ReadLine();
            while (!sr.EndOfStream) dolgozo.Add(new Dolgozok(sr.ReadLine()));
            
            Console.WriteLine($"Az átlag életkor: {KorAtlag(dolgozo)}");
            Console.WriteLine($"Budapesten élők száma: {VarosBP(dolgozo)}");
            Console.WriteLine($"A legidősebb személy: {dolgozo[Legidosebb(dolgozo)].ToString()}");
            Console.WriteLine($"Harminc év fölötti személy: {HarmincPlus(dolgozo)}");

            Console.ReadKey();
        }
        static double KorAtlag(List<Dolgozok> a)
        {
            
            double atlag = 0;
            for (int i = 0; i < a.Count; i++)
            {
                atlag += a[i].age;
            }
            return atlag / a.Count;
        }
        static int VarosBP(List<Dolgozok> v)
        {
            int BpLakok = 0;
            for (int i = 0; i < v.Count; i++)
            {
                if (v[i].city == "Budapest")
                {
                    BpLakok += 1;
                }
            }
            return BpLakok;
        }
        static int Legidosebb(List<Dolgozok> d)
        {
            int index = 0;
            int legidosebb = d[0].age;

            for (int i = 1; i < d.Count; i++)
            {
                if (d[i].age> legidosebb)
                {
                    legidosebb = d[i].age;
                    index = i;
                }
            }


            return index;
        }
        static string HarmincPlus(List<Dolgozok> d)
        {
            int index = 0;
            string neve = string.Empty;
            int Rn = 0;
            for (int i = 0; i < d.Count; i++)
            {
                if (d[i].age >= 30)
                {
                    Rn += 1;
                    neve = d[i].name;
                    index = i;
                }
            }

            return $"{Rn} {neve}";
        }

    }
}
