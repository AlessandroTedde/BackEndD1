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

            Animal animal1 = new Animal()
            {
                Race = "Mammal",
                Name = "Blue whale",
                Habitat = "Sea"
            };

            Employee employee1 = new Employee()
            {
                Name = "Ciro",
                Surname = "Esposito",
                Job = "Carpenter"
            };

            Vehicle vehicle1 = new Vehicle() 
            { 
                Manufacturer = "Suzuki",
                Model = "Escudo Pikes Peak",
                Hp = 985
            };
            Console.WriteLine("Athletes section:");
            Console.WriteLine("\n");
            Console.WriteLine(athlete1.Name);
            Console.WriteLine(athlete1.Surname);
            Console.WriteLine(athlete1.Sport);
            Console.WriteLine("\n");
            athlete1.goldMedals(athlete1.Name, athlete1.Surname, 130);
            Console.WriteLine("\n");
            Console.WriteLine("Animals section:");
            Console.WriteLine("\n");
            Console.WriteLine(animal1.Race);
            Console.WriteLine(animal1.Name);
            Console.WriteLine(animal1.Habitat);
            Console.WriteLine("\n");
            animal1.weight(animal1.Name, 140000);
            Console.WriteLine("\n");
            Console.WriteLine("Employees section:");
            Console.WriteLine("\n");
            Console.WriteLine(employee1.Name);
            Console.WriteLine(employee1.Surname);
            Console.WriteLine(employee1.Job);
            Console.WriteLine("\n");
            Console.WriteLine(employee1.retirement(employee1.Name, employee1.Surname, 67));
            Console.WriteLine("\n");
            Console.WriteLine("Vehicles section:");
            Console.WriteLine("\n");
            Console.WriteLine(vehicle1.Manufacturer);
            Console.WriteLine(vehicle1.Model);
            Console.WriteLine(vehicle1.Hp + "CV");
            Console.WriteLine("\n");
            vehicle1.maxSpeed(vehicle1.Manufacturer, vehicle1.Model, 205);
            Console.ReadLine();
        }
    }
}
