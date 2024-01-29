using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndD1
{
    public class Employee
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


        private string _job;
        public string Job
        {
            get { return _job; }
            set { _job = value; }
        }
        public string retirement(string Name, string Surname, int age)
        {
            if (age > 65) 
            {
                return $"{Name} {Surname} is next to retirement";
            } else if (age < 18)
            {
                return $"{Name} {Surname} is too young, hence unemployable";
            }
            else
            {
                return $"{Name} {Surname} is not close to retirement";
            }
        }
    }
}
