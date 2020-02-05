using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class CleanCar : Car
    {


        public CleanCar()
        {
            passengers = generator.Next(0, 4);
            contrabandAmount = 0;

            Console.WriteLine("Passagerare: " + passengers + "\n");

            if (Examine() == true)
            {
                Console.WriteLine("Stöldgods hittat!");
                Console.WriteLine("Stöldgods: " + contrabandAmount + "\n");
            }

            else if (Examine() == false)
            {
                Console.WriteLine("Stöldgods EJ hittat!\n");
            }
        }
    }
}
