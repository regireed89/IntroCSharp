using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Timers;

namespace TrafficLightFSM
{
    class Program
    {
        static void Main(string[] args)
        {
        }
       public class StopWatch
        {
            public StopWatch(){ }
        }
        public class FSM<T>
        {
            public FSM() { }
            public void Start(){ }
            public void Update() { }
            public void Feed() { }
        }

        public class State
        {
            public State() { }
         enum states
            {
                Init = 0,
                Red = 1,
                Green = 2,
                Yellow = 3,
                Exit = 9000
            };

        }

        public class Transition
        {
            public Transition() { }

        }



    }
}
