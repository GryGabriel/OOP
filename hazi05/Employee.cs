using System;
using System.Collections.Generic;
using System.Text;

namespace hazi05
{
    class Employee
    {
        private string nev;
        private int fizetes;

        public int Fizetes
        {
            get { return fizetes; }
            set { fizetes = value; }
        }

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public void FizetesNoveles(int fizetes)
        {
            this.fizetes += fizetes;
        }

        public string Osszefuzes()
        {
            return $"{nev} fizetese: {fizetes}";
        }
        public bool IsInRange(int upper, int lower)
        {
            if(fizetes <= upper && fizetes >= lower)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Tax()
        {
            return fizetes*0.16;
        }

        public bool HigherSalary(Employee secondEmployee)
        {
            if(fizetes > secondEmployee.fizetes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Employee(string nev, int fizetes)
        {
            this.nev = nev;
            this.fizetes = fizetes;
        }
        public Employee(string nev) : this(nev, 250000)
        {
        }
        public override string ToString()
        {
            return $"Az alkalmazott neve: {nev}, fizetése: {fizetes}";
        }
    }
}
