using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class ContrabandCar : Car
    {


        public ContrabandCar()
        {
            passengers = generator.Next(0, 5);
            contrabandAmount = generator.Next(0, 5);

            Console.WriteLine("Passagerare: " + passengers);

            if (Examine() == true)
            {
                Console.WriteLine("Stöldgods hittat!");
                Console.WriteLine("Stöldgods: " + contrabandAmount);
            }

            else if (Examine() == false)
            {
                Console.WriteLine("Stöldgods EJ hittat!");
            }
        }
    }
}
