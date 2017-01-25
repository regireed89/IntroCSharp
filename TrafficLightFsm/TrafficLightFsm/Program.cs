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
        Exit = 9000
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


    public class FSM<T>
    {
        public FSM() { }
        public void ChangeState(State state) { }
        public bool AddState(State state) { return false; }

        public bool AddTransition<V>() { return false; }

        public void Start() { }
        public void Update() { }
        public void Feed() { }
    }


    

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
