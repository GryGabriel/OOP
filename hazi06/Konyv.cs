using System;
using System.Collections.Generic;
using System.Text;

namespace konyvNevter
{
    class Konyv
    {
        private string cim;
        private string szerzo;
        private readonly int megjelenesEve = DateTime.Now.Year;
        private int ar;
        private int oldalszam;
        private static string kiado = "Móra";

        public int Oldalszam
        {
            get { return oldalszam; }
            set { oldalszam = value; }
        }


        public Konyv(string cim, string szerzo, int oldalszam, int ar)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.ar = ar;
            this.oldalszam = oldalszam;
        }

        public Konyv(string cim, string szerzo, int oldalszam) : this(cim, szerzo, oldalszam, 2500)
        {

        }

        public int Ar
        {
            get { return ar; }
            set { ar = value; }
        }

        public string Szerzo
        {
            get { return szerzo; }
            set { szerzo = value; }
        }

        public string Cim
        {
            get { return cim; }
            set { cim = value; }
        }

        public void ArNoveles(int szazalek)
        {
            ar += ar * szazalek / 100;
        }

        public string Osszefuz()
        {
            return $"A könyv címe: {cim},\nSzerzője: {szerzo},\nA kiadó: {kiado},\nMegjelenésének éve: {megjelenesEve},\nOldalszáma: {oldalszam},\nÁra: {ar}\n ";
        }

        public override string ToString()
        {
            return $"A könyv címe: { cim},\nSzerzője: { szerzo},\nA kiadó: {kiado},\nMegjelenésének éve: { megjelenesEve},\nOldalszáma: {oldalszam},\nÁra: { ar}\n";
        }

        public static Konyv HosszabbKonyv(Konyv konyv1, Konyv konyv2)
        {
            if(konyv1.oldalszam > konyv2.oldalszam)
            {
                return konyv1;
            }
            else
            {
                return konyv2;
            }
        }

        public bool ParosE()
        {
            if(oldalszam%2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
