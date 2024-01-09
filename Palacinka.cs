using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_name
{
    class stablo
    {
        bool otpadajuListovi;
        string vrstaStabla;

        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
        public string VrstaStabla { get => vrstaStabla; set => vrstaStabla = value; }

        public stablo() { }

        public stablo (bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
        }

        public override string ToString()
        {
            string ispis = "Ovo stablo je: ";

            if(otpadajuListovi)
            {
                ispis += "Listopadno.";
            }

            else
            {
                ispis += "Zimzeleno.";
            }

            return ispis;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            stablo stablo1 = new stablo(false);
            stablo stablo2 = new stablo(true);

            Console.WriteLine ("Stablo 1: " + stablo1.ToString());
            Console.WriteLine("Stablo 2: " + stablo2.ToString());

            Console.WriteLine(stablo1.OtpadajuListovi);
            Console.ReadKey();
        }
    }
}
