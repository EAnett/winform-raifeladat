using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformóraifeladat
{
    class autocl
    {
        string rendszam1;
        string rendszam2;
        string tipus;
        int gyartmany;
        string teljesitmeny;

        public string Rendszam1 { get => rendszam1; set => rendszam1 = value; }
        public string Rendszam2 { get => rendszam2; set => rendszam2 = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public int Gyartmany { get => gyartmany; set => gyartmany = value; }
        public string Teljesitmeny { get => teljesitmeny; set => teljesitmeny = value; }

        public autocl(string rendszam1, string rendszam2, string tipus, int gyartmany, string teljesitmeny)
        {
            this.rendszam1 = rendszam1;
            this.rendszam2 = rendszam2;
            this.tipus = tipus;
            this.gyartmany = gyartmany;
            this.teljesitmeny = teljesitmeny;
        }

        public override string ToString()
        {
            return rendszam1 + "-" + rendszam2 + " " + gyartmany + " " + " (" + teljesitmeny+ " " + "lóerő ) ";
        }
    }
}
