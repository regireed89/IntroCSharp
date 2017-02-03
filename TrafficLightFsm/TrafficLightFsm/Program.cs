using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Timers;

namespace TrafficLightFSM
{

    public enum LightState
    {
        Init = 0,
        Red = 1,
        Green = 2,
        Yellow = 3,
        Exit = 4
    };

    public class FSM
    {
       // LightState currentstate;
        int currentlight = 0;
        public FSM() { }
        public void Start()
        {
            //currentstate = LightState.Init;

            while (true)
            {
                currentlight = Convert.ToInt32(Console.ReadLine());
                switch (currentlight)
                {
                    case 1:
                        Console.WriteLine("i am green");
                        break;
                    case 2:
                        Console.WriteLine("i am yellow");
                        break;
                    case 3:
                        Console.WriteLine("i am red");
                        break;
                    case 4:
                        Console.WriteLine("i am leaving");
                        break;

                }
            }
        }

        //public void ToGreen()
        //{
        //    currentstate = LightState.Green;
        //    Console.WriteLine("I am green");
        //}

        //public void ToYellow()
        //{
        //    currentstate = LightState.Yellow;
        //    Console.WriteLine("I am yellow");
        //}

        //public void ToRed()
        //{
        //    currentstate = LightState.Red;
        //    Console.WriteLine("I am red");
        //}

        //public void ToExit()
        //{
        //    currentstate = LightState.Exit;
        //    Console.WriteLine("I am leaving");
        //}


    }
    class Program
    {
        static void Main(string[] args)
        {
            FSM fsm = new FSM();
            fsm.Start();

        }
    }
}
