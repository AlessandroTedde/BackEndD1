﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndD1
{
    public class Athlete
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }


        private string _sport;
        public string Sport
        {
            get { return _sport; }
            set { _sport = value; }
        }

        public void goldMedals(string Name, string Surname, int quantity) {
            Console.WriteLine($"{Name} {Surname} has {quantity} gold medals");
        }
    }
}
    


