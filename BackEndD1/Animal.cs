using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndD1
{
    public class Animal
    {
        private string _race;
        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private string _habitat;
        public string Habitat
        {
            get { return _habitat; }
            set { _habitat = value; }
        }

        public void weight(string animal, int weight)
        {
            Console.WriteLine($"The {animal} weighs {weight}kg on average");
        }
    }
}
