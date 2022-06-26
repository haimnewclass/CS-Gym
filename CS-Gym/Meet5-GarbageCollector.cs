using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gym
{
    internal class Meet5_GarbageCollector
    {
        public Stack<Car> cars = new Stack<Car>();
        public event Action EventHandler ;
        public void Run()
        {            
            for (int i = 0; i < 100000; i++)
            {
                Car car = new Car();
                cars.Push(new Car());
            }
            //memory allocation
            //free memory

            // disadvantages CG
            // defregmentation
            // freeze threads

            // relase huge memory
            // run the GC free memory process
            GC.Collect();

            // Memory leaks
            for (int i = 0; i < 10000; i++)
            {
                Screen screen = new Screen();
                EventHandler += screen.Run;
            }
        }

        private void Meet5_GarbageCollector_CarChanged(object? sender, Car e)
        {
            throw new NotImplementedException();
        }

        public class CarPool
        {
            private Stack<Car> cars = new Stack<Car>();
            public CarPool()
            {
                for (int i = 0; i < 100; i++)
                {
                    cars.Push(new Car());
                }
            }
            public Car Alloctte()
            {
                return null;
            }

            public void Free(Car car)
            {

            }

        }

        public class Screen
        {         
            public void Run()
            {

            }
        }





    }
}
