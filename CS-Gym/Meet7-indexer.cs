using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gym
{
    internal class Meet7_indexer
    {

        public void Run()
        {
            Rooms rooms = new Rooms();
            Room room5 = rooms[23];
        }
    }

    class Room
    { }


    class Rooms
    {
        Room defaultRoom = new Room();
        Room[] _rooms = new Room[1000];
        public Room this[int roomIdx]
        {
            get { 
                if(roomIdx<100)
                {
                    return defaultRoom;
                }
                
                return _rooms[roomIdx]; }
            set { _rooms[roomIdx] = value; }        
        }

    }

}
