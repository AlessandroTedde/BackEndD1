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
    }
}
