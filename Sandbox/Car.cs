using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public enum Vedligehold
    {
        God, 
        Dårlig, 
        Midddel, 
        MegetGod
    }

    public enum Type
    {
        StationCar, 
        Sedan, 
        HatchBack, 
        Cross, 
        MiniCross
    }

    public class Car
    { 
        //private string stand; 
        public Vedligehold Stand { get; set; }

        public Type Type { get; set; }

        public int Speed { get;  }
        public string Model { get; }

        private string _regnr;

        public string Regnr
        {
            get { return _regnr; }
            set { _regnr = value; }
        }

        
        public Car(string regnr, int speed, string model)
        {
            _regnr = regnr;
            Speed = speed;
            Model = model;
        }

        public Car()
        {
            _regnr = "Intet registreringsnr";
            Model = "No name";
            Speed = 0;
        }

        public Car(string regnr, Vedligehold stand, int speed, string model)
        {
            _regnr = regnr;
            Stand = stand;
            Speed = speed;
            Model = model;
        }

        public Car(string regnr, Vedligehold stand, Type type, int speed, string model)
        {
            _regnr = regnr;
            Stand = stand;
            Type = type;
            Speed = speed;
            Model = model;
        }

    }
}
