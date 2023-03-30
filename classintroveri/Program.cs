using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classintroveri
{
    class Program
    {
        static void Main(string[] args)
        {
            

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin demirog";
            kurs1.izlenme = 68;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "java";
            kurs2.egitmen = "Engin demirog";
            kurs2.izlenme = 35;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "pythoon";
            kurs3.egitmen = "Engin demirog";
            kurs3.izlenme = 124;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs1.egitmen);
            }




        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenme { get; set; }
    }
}
