using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Car
    {
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

    }
}
