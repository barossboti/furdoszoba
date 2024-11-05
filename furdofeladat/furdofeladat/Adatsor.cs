using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furdofeladat
{
    internal class Adatsor
    {
        public int vendegazonosito {get; set; }
        public int furdoazonosito { get; set; }
        public bool belep { get; set; }
        public int ora { get; set; }
        public int perc { get; set; }
        public int mp {  get; set; }
        public Adatsor(string sor)
        {
            string[] sz = sor.Split(' ');
            vendegazonosito = int.Parse(sz[0]);
            furdoazonosito = int.Parse(sz[1]);
            if(int.Parse(sz[2]) == 0 )
            {
                belep = true;
            }
            ora = int.Parse(sz[3]);
            perc = int.Parse(sz[4]);
            mp = int.Parse(sz[5]);
        }
    }
}
