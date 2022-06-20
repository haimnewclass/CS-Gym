using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gym
{
    internal class Meet3_RefVal
    {
        public void run()
        {
            Label l = new Label();
            l.Text = "456";
            ChangeLabel(l);
            int[] arr = new int[100];
            int a = 10;
            int b;
            Change(ref a,out b);
        }


        public void ChangeLabel(Label l)
        {
            string s = "";

          
            object o = s;


            l.Text = "123";           
        }

        public void Change(ref int a,out int b )
        {
            a++;
            b = a * a;
           
        }

        public void Val()
        {
            //System.ValueType vs Object
            int a;
            // a = null; // not nullabale

            int? b;
            b = null;
            
            if(b==null)
            {

            }

            if(b is null)
            {

            }

            if(b.HasValue)
            {

            }
            
            b ??= 2;

            Label l = null;

            l ??= new Label();

            if (l != null)
            {
                l = new Label();
            }



        }

    }
}
