using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gym
{

    class MakeBigRequest:IDisposable
    {
        public void Dispose()
        {
            Release();
        }

        public void Operate()
        {
            // takes huge memory

            // create temp DB
        }

        public void Release()
        {
            // drop temp DB
        }
    }

    internal class Meet6_idispose
    {
        public void Run()
        {
            MakeBigRequest makeBigRequest = new MakeBigRequest();
            makeBigRequest.Operate();


            // release resources
           // makeBigRequest.Release();

            //makeBigRequest.Dispose();

            using(MakeBigRequest makeBigRequest1 = new MakeBigRequest())
            { 
                makeBigRequest1.Operate();
            }

            

            

        }
    }
}
