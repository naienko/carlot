using System;
using System.Collections.Generic;

namespace carlot
{
    class Program
    {
        static void Main()
        {
            /*Define a Dictionary to represent a car. Each dictionary should have the following KeyValuePairs.

* Make
* Model
* Year
* Price

Create three car dictionaries for three different car models

* Create a car lot list.
* Add each car to the car lot.
* Iterate the car lot list and output all the details of each car */

            Dictionary<string, string> delSol = new Dictionary<string, string>();
            delSol.Add("make", "Honda");
            delSol.Add("model", "del Sol");
            delSol.Add("year", "1999");
            delSol.Add("price", "5400");

            Dictionary<string, string> three = new Dictionary<string, string>();
            three.Add("make", "Mazda");
            three.Add("model", "3");
            three.Add("year", "2015");
            three.Add("price", "10500");

            Dictionary<string, string> Fiero = new Dictionary<string, string>();
            Fiero.Add("make", "Pontiac");
            Fiero.Add("model", "Fiero");
            Fiero.Add("year", "1979");
            Fiero.Add("price", "1500");

            List<Dictionary<string, string>> carLot = new List<Dictionary<string, string>>();
            carLot.Add(delSol);
            carLot.Add(three);
            carLot.Add(Fiero);

            foreach (Dictionary<string, string> vehicle in carLot) {
                foreach (KeyValuePair<string, string> detail in vehicle) {
                    Console.WriteLine($"{detail.Key}: {detail.Value}");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
