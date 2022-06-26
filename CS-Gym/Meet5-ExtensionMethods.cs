using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gym
{
    public class Utilities
    { 
        public static int DotsCounter(string str)
        {
            return str.Split('.').Count() - 1;
        }
    }


    /*
    public class MyString : string {
        public int DotsCounter(string str)
        {
            return str.Split('.').Count() - 1;
        }
    }
    */

    public static class ExtStringMethods
    {
        public static int DotsCounter(this string str)
        {
            return str.Split('.').Count() - 1;
        }

        public static bool HasMobily(this Car car,int Year)
        {
            if(Year >= 2022)
            {
                return true;
            }

            if (car.GetPrice() > 90000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    internal class Meet5_ExtensionMethods
    {
        public void Run()
        {

            //MyString s = "abcd.ssdf.234.dfg.345.sfg.45";
            string s = "abcd.ssdf.234.dfg.345.sfg.45";
            int a = s.DotsCounter();
            a = Utilities.DotsCounter(s);

            Car car = new Car();

            car.HasMobily(2022);
            
        }

        public int DotsCounter(string str)
        {
            return str.Split('.').Count()-1;
        }
    }

    public class Car
    {
        public int GetPrice()
        {
            return 100000;
        }    
    }

}
