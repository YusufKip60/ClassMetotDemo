using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin Demiroğ";
            int yas = 36;

            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Yusuf Kip";
            kurs2.IzlenmeOranı = 64;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "Phthon";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOranı = 80;

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOranı);
            }



           // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);



            
        }
    }

    class kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOranı { get; set; }
    }
}
