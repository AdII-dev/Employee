using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Dolgozok
    {
        
        public string name { get; set; }
        public int age { get; set; }
        public string city { get; set; }
        public string position { get; set; }
        public string gender { get; set; }
        public string martialStatus { get; set; }
        public double salaryEUR { get; set; }
    
        public Dolgozok(string sor)
        {
            string[] atmeneti = sor.Split(';');
            name = atmeneti[0];
            age = Convert.ToInt32(atmeneti[1]);
            city = atmeneti[2];
            position = atmeneti[3];
            gender = atmeneti[4];
            martialStatus = atmeneti[5];
            salaryEUR = Convert.ToInt32(atmeneti[6]);

        }
        public void Kiir()
        {
            Console.WriteLine($"Név: {name}, Kor: {age}, Város: {city}, Pozíció: {position}, Nem: {gender}, Kapcsolata: {martialStatus}, Fizetés: {salaryEUR} ");
        }
        
    }
}
