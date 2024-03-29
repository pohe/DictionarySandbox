﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Car c1 = new Car("AV 12345678", 220, "Skoda");
            Car c2 = new Car("BZ 87654321", 180, "VW");
            Car c3 = new Car("TD 55555", 250, "BMW");
            Car c4 = new Car("AZ 12345678", 280, "Peugout");

            c4.Stand = Vedligehold.God;
            Console.WriteLine($"Tilstanden af bilen AZ 12345678 er {c4.Stand}");

            Car c6 = new Car("99999", Vedligehold.MegetGod, 400, "Mercedes");

            Console.WriteLine("Skriv tilstanden af C3");
            string standenAfC3 = Console.ReadLine();
            if (standenAfC3 == "God")
            { 
                c3.Stand = Vedligehold.God;
            }
            else if (standenAfC3 == "Dårlig")
            {
                c3.Stand = Vedligehold.Dårlig;
            }
            Console.WriteLine("Standen af C3 er " + c3.Stand);

            switch (c3.Stand)
            {
                case Vedligehold.God: Console.WriteLine("Good");
                break;
                case Vedligehold.Dårlig: Console.WriteLine("Bad");
                    break;
                case Vedligehold.MegetGod: Console.WriteLine("Very good");
                    break;
                default: Console.WriteLine("Ikke registreret");
                    break;
            }


            Car c7 = new Car("2323232", Vedligehold.MegetGod, Type.StationCar, 300, "Volvo");
            Dictionary<string, Car>cars = new Dictionary<string, Car>();
            //cars.Add("AV 12345678", c1);
            cars.Add(c1.Regnr, c1);
            cars.Add(c2.Regnr, c2);
            cars.Add(c3.Regnr, c3);
            if ( ! cars.ContainsKey(c4.Regnr))
                cars.Add(c4.Regnr, c4);

            Console.WriteLine("Alle keys i Dictionary");
            foreach (string aKey in cars.Keys)
            {
                Console.WriteLine(aKey);
            }

            Car c5 = new Car("555", 50, "Trabant");
            cars[c5.Regnr] = c5;


            bool  c5Removed = cars.Remove(c5.Regnr); 
            if (c5Removed)
                Console.WriteLine("C5 objektet er fjernet");
            Console.WriteLine("Alle values i Dictionary");
            foreach (Car aCar in cars.Values)
            {
                Console.WriteLine($"Bilen regnr {aCar.Regnr} og model {aCar.Model} og speed {aCar.Speed}");
            }

            
            Console.WriteLine("My car udskrives");
            if (cars.ContainsKey("AV 12345678"))
            {
                Car myCar = cars["AV 12345678"];
                Console.WriteLine($"Bilen regnr {myCar.Regnr} og model {myCar.Model} og speed {myCar.Speed}");
            }
            
            //Car theCar = cars.ContainsKey("AV 12345678") ? cars["AV 12345678"] : null;
            //if (theCar != null)
            //    Console.WriteLine($"Bilen regnr {theCar.Regnr} og model {theCar.Model} og speed {theCar.Speed}");
            string theKey = "AV 12345678";
            Console.WriteLine(cars.ContainsKey(theKey)? $"Bilen regnr {cars[theKey].Regnr} og model {cars[theKey].Model} og speed {cars[theKey].Speed}" : "Bilen findes ikke"  );

            //Car myCar = cars["AV 1234"];
            //if (myCar != null)
            //    Console.WriteLine($"Bilen regnr {myCar.Regnr} og model {myCar.Model} og speed {myCar.Speed}");
            
            
            
            // The LAST line of code should be ABOVE this line
        }
    }
}