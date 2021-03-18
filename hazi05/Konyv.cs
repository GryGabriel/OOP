using System;
using System.Collections.Generic;
using System.Text;

namespace hazi05
{
    class Konyv
    {
        private string cim;
        private string szerzo;
        private int megjelenesEve;
        private int ar;

        public int Ar
        {
            get { return ar; }
            set { ar = value; }
        }

        public int MegjelenesEve
        {
            get { return megjelenesEve; }
            set { megjelenesEve = value; }
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

        public void Arnoveles(int szazalek)
        {
            ar += ar * (szazalek / 100);
        }
        public string Osszefuz()
        {
            return $"A könyv címe: {cim}, szerzője: {szerzo}, megjelenésének éve: {megjelenesEve}, ára: {ar}";
        }

        public Konyv(string cim, string szerzo, int megjelenesEve, int ar)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.megjelenesEve = megjelenesEve;
            this.ar = ar;
        }

        public Konyv(string cim, string szerzo)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            ar = 2500;
            DateTime currentDate = DateTime.Now;
            megjelenesEve = currentDate.Year;
        }
        public override string ToString()
        {
            return $"A könyv címe: {cim}, szerzője: {szerzo}, megjelenésének éve: {megjelenesEve}, ára: {ar}";
        }
    }
}
