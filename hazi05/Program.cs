using System;

namespace hazi05
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Rogán Antal", 320000);
            Console.WriteLine(employee);
            employee.FizetesNoveles(120000);
            Console.WriteLine(employee);
            Console.WriteLine(employee.IsInRange(450000, 300000));
            Console.WriteLine($"A fizetendő adó: {employee.Tax()}");
            Employee secondEmployee = new Employee("Samantha Carter", 340000);
            Console.WriteLine($"A fizetes nagyobb: {employee.HigherSalary(secondEmployee)}");
            Employee[] employees = new Employee[5];
            for (int i = 0; i < employees.Length; i++)
            {
                Console.Write($"Add meg a(z) {i}. alkalmazott nevét és fizetését: ");
                employees[i] = new Employee(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            }
            int maxIndex = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                if(employees[i].Fizetes > employees[maxIndex].Fizetes)
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine($"A legmagasabb fizetéssel rendelkező alkalmazott: {employees[maxIndex].Nev}, fizetése: {employees[maxIndex].Fizetes}");
            int db = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                if(employees[i].IsInRange(450000, 250000))
                {
                    db++;
                }
            }
            Console.WriteLine($"{db} alkalmazott fizetése esik 250000 és 450000 ft közé.");
            int atlagFizetes = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                atlagFizetes += employees[i].Fizetes;
            }
            atlagFizetes /= employees.Length;
            Console.WriteLine($"Az alkalmazottak átlagfizetése: {atlagFizetes}");
            double osszAdo = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                osszAdo += employees[i].Tax();
            }
            Console.WriteLine($"Az alkalmazottak által  befizetett adó összértéke: {osszAdo}");

            Konyv konyv = new Konyv("A kendőzetlen igazság", "Bakó Csaba", 2019, 3990);
            Console.WriteLine(konyv);
        }
    }
}
