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


        private int _hp;
        public int Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }
        public void maxSpeed(string Manufacturer, string Model, int Speed)
        {
            Console.WriteLine($"{Manufacturer} {Model} can reach a max speed of {Speed}Km/h");
        }
    }
}
