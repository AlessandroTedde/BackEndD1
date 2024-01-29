using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndD1
{
    public class Vehicle
    {
        private string _manufacturer;
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }


        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }


        private string _hp;
        public string Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }
    }
}
