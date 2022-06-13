using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gym
{
    internal class Meet1_delegate
    {
        public delegate int CalcFunc(int a, int b);

        public void Run()
        {
            CalcFunc f;
            f = Calc1;
            int r = f(4, 4);

            f = Calc2;
            r = f(4, 4);
            r = Calc2(4, 4);

            CalcTax(200, Calc1);
            CalcTax(200, Calc2);
            CalcTax(200, Calc3);

        }

        public int CalcTax(int price,CalcFunc func)
        {
            return (func(price, 20));
        }

        public int Calc1(int a,int b)
        {
            return a * b;
        }
        public int Calc2(int a, int b)
        {
            return a + b;
        }
        public int Calc3(int a, int b)
        {
            return a - b;
        }

    }

}
