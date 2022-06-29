using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gym
{
    internal class Meet6_check
    {
        public void Run()
        {
            int c = 0;

            try
            {
               

                checked
                {
                    byte a = 1;
                    a = byte.MaxValue - 2;
                    a++;
                    a++;                    
                    unchecked
                    {
                        a++;
                    }
                    a = byte.MaxValue;
                    a++;
                }
            }
            catch (OverflowException ex)
            {

            }

            int b = 2;
            b = int.MaxValue - 1;
            b++;
            b++;
            b++;
            b++;
            b++;
            for (long i = 0; i < long.MaxValue; i++)
            {
                c++;
                b++;
            }

        }
    }
}
