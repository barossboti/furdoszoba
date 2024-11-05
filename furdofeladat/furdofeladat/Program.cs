using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace furdofeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            List<Adatsor> adatok = new List<Adatsor>();
            string[] fajl = File.ReadAllLines("furdoadat.txt",Encoding.UTF8);
            for(int i = 0; i < fajl.Length; i++)
            {
                adatok.Add(new Adatsor(fajl[i]));
            }
            //2. feladat
            var feladat2 = adatok.Where(x=>x.belep == false && x.furdoazonosito == 0).ToList();

            Console.WriteLine($"2. feladat: Az első vendég {feladat2[0].ora}:{feladat2[0].perc}:{feladat2[0].mp} lépett ki az öltözőből. ");
            //3. feladat
            Console.WriteLine("3. feladat");
            var feladat3 = adatok.GroupBy(x => x.vendegazonosito);
            foreach (var item in feladat3 ) {
                Console.WriteLine($"{item.Count()}");

            }
            //4. feladat
            Console.WriteLine("4. feladat");
            var feladat4 = adatok.Where(x => x.belep == false && x.furdoazonosito ==0 ).ToList();
            foreach (var item in feladat4) { 
            Console.WriteLine($"A legtöbb időt eltöltő vendég:\t {item.vendegazonosito}");
            }

            //5. feladat

            //6. feladat
            Console.WriteLine("6. feladat: szauna.txt");
            List<string> kimenet = new List<string>();

            var feladat6 = adatok.Where(x => x.belep == false && x.furdoazonosito == 0).ToList();
            foreach (var item in feladat6)
            {
                kimenet.Add($"{feladat6[0].vendegazonosito} {feladat6[0].ora}:{feladat6[0].perc}:{feladat6[0].mp} ");
            }
            File.WriteAllLines("szauna.txt",kimenet);


            //7. feladat

            Console.WriteLine("7 feladat");
            var feladat7 = adatok.GroupBy(x => x.furdoazonosito);
            foreach (var item in feladat7)
            {
                Console.WriteLine($"\t{item.Key} {item.Count()}db");
            }

            Console.ReadKey();

        }
    }
}
