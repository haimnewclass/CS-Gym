using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gym
{
    internal class Meet2_foreach
    {
        public void Run()
        {
            LinkedList<string> list = new LinkedList<string>();
            var a = list.ToArray();
            for(int i = 0; i < a.Length; i++)
            {
                
            }


            int[] arr = new int[100];
            int sum = 0;
            foreach(int i in arr)
            {
                sum = sum + i;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
        }

        public void RunMyItems()
        {
            Items items = new Items();
            string allStr = "";
            foreach (var item in items)
            {
                allStr += item.ToString();
            }
            foreach (var item in items)
            {
                allStr += item.ToString();
            }
        }
    }



    public class Items:IEnumerable, IEnumerator
    {
        public string[] list = { "Ball", "Shirt", "CD", "TV" };
        int idx = -1;
        public object Current
        {
            get
            {
                if (idx == 0)
                {
                    return "start";
                }
                else
                {
                    return list[idx];
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            // condition
            if(idx< list.Length-1)
            {
                idx++;
                return true;
            }
            else
            {
                return false;
            }
            // jump to next position
        }

        public void Reset()
        {
            idx = -1;
        }
    }

}
