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


    public class State
    {
        public State() { }
        public State(Enum e)
        {
            name = e.ToString();
        }
        public string name;
        public delegate void OnEnter();
        public delegate void OnExit();
        public OnEnter onEnter;
        public OnExit onExit;

        public void AddEnterFunction(Delegate d)
        {
            onEnter += d as OnEnter;
        }
    }


    public class FSM
    {
        LightState currentstate;

        public FSM() { }
        public LightState ChangeState(LightState currentlight, LightState next)
        {
            currentlight = next;
            currentstate = currentlight;
            return currentstate;
        }
        public bool AddState(LightState state)
        {
            return false;
        }         

        public bool IsTransitionValid()
        {
            return false;
        }
        public void Start()
        {           
            currentstate = LightState.Init;
        }

        public void Update()
        {
          
        }
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
