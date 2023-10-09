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
        public string department { get; set; }
        public string gender { get; set; }
        public string martialStatus { get; set; }
        public double salaryEUR { get; set; }
    
        public Dolgozok(string sor)
        {
            var atmeneti = sor.Split(';');
            name = atmeneti[0];
            age = Convert.ToInt32(atmeneti[1]);
            city = atmeneti[2];
            department = atmeneti[3];
            position = atmeneti[4];
            gender = atmeneti[5];
            martialStatus = atmeneti[6];
            salaryEUR = Convert.ToDouble(atmeneti[7]);

        }
        public override string ToString()//virtuális metódus
        {
            return $"Név: {name}, Kor: {age}, Város: {city}, Pozíció: {position}, Nem: {gender}, Kapcsolata: {martialStatus}, Fizetés: {salaryEUR} ";
        }
        

        
    }
}
