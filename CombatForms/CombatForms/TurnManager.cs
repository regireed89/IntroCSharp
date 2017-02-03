﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatForms
{
    class TurnManager
    {
    }
    public enum PlayerStates
    {
        INIT = 0,
        IDLE = 1,
        ATTACK = 2,
        ENDTURN = 3,
        DEAD = 4,
    }
    
    public class FSM
    {
        private PlayerStates currentstate;
        public FSM()  { }
            Dictionary<string, List<State>> states_dictionary = new Dictionary<string, List<State>>();

        public void Start()
        {
            currentstate = PlayerStates.INIT;
        }
        public void Update() { }
        public void Exit() { }
    }

    public class State
    {
        public State() { }
        public State(string s)
        {
            name = s;
        }
        public string name;
        List<State> states = new List<State>();
        

        public delegate void OnEnter();
        public delegate void OnExit();
        public OnEnter onEnter;
        public OnExit onExit;
        public void AddStates(State s)
        {
            states.Add(s);
        }
    }
}


