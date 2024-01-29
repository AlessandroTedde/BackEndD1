using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BackEndD1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Athlete athlete1 = new Athlete()
            {
                Name = "Federica",
                Surname = "Pellegrini",
                Sport = "Nuoto"
            };
            Console.WriteLine(athlete1.Name);
            Console.WriteLine(athlete1.Surname);
            Console.WriteLine(athlete1.Sport);
            Console.WriteLine("\n");
            athlete1.goldMedals(athlete1.Name, athlete1.Surname, 130);
            Console.ReadLine();
        }
    }
}
