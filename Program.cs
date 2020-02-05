using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            bool loopcheck = false;
            int cars = 0;

            Console.WriteLine("Hur många bilar ska skapas?");

            while (loopcheck == false)
            {
                string input = Console.ReadLine();
                int.TryParse(input, out cars);

                if (cars < 1)
                {
                    Console.WriteLine("Please enter a number above 0.");
                    loopcheck = false;
                }

                else if (cars > 0)
                {
                    loopcheck = true;
                }
            }

            Console.WriteLine(cars);

            var carList = new List<Car>();

            for (int i = 0; i < cars; i++)

            
            {
                int random = generator.Next(0, 3);

                if (random == 1)
                {
                    carList.Add(new ContrabandCar { Id = "car" + i });
                }

                else if (random == 2)
                {
                    carList.Add(new CleanCar { Id = "car" + i });

                }
                
            }

            // for (int i = 0; i < carList.Count; i++)


            Console.ReadKey();
        }
    }
}
