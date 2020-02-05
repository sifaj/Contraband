using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contraband
{
    class Car
    {
        public string Id { get; set; }
        public int passengers = 0;
        public int contrabandAmount = 0;
        public bool alreadyChecked = false;
        public Random generator = new Random();


        public bool Examine()
        {

            int random = 0;

            if (contrabandAmount == 1)
            {
                random = generator.Next(0, 6);

                if (random == 1)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            if (contrabandAmount == 2)
            {
                random = generator.Next(0, 5);

                if (random == 1)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            if (contrabandAmount == 3)


            {
                random = generator.Next(0, 4);


                if (random == 1)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            if (contrabandAmount == 4)
            {
                random = generator.Next(0, 3);

                if (random == 1)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            else if (contrabandAmount == 0)
            {
                return false;
            }

            alreadyChecked = true;

            return false;
        }

    }
}
