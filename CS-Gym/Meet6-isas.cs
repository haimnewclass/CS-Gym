using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gym
{
    class aaa { }
    class bbb { }
    class ccc : aaa { 
    public void Run_ccc()
        {

        }
    }


    internal class Meet6_isas
    {
        public void Run()
        {
            aaa a = new aaa();
            bbb b = new bbb();
            ccc c = new ccc();
            Operate(c);
        }

        public void Operate(object o)
        {
            bool test = o is aaa;
            test = o is bbb;
            test = o is ccc;
            test = o is object;
            test = o is System.IO.FileStream;

            if(o is ccc)
            {
                // reference type
                ccc c = o as ccc;
                c = (ccc)o;
                
                //run method
                c.Run_ccc();
            }
            
        }
    }
}
